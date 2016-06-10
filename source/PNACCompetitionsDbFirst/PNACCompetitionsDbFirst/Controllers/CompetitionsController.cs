using PNACCompetitionsDbFirst.Controllers;
using PNACCompetitionsDbFirst.Entities;
using PNACCompetitionsDbFirst.Models;
using PNACCompetitionsDbFirst.Models.ViewModels;
using PNACCompetitionsDbFirst.Models.ViewModels.Components;
using PNACCompetitionsDbFirst.Models.ViewModels.Entries;
using PNACCompetitionsDbFirst.Models.ViewModels.Catches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using static PNACCompetitionsDbFirst.Models.ViewModels.CompetitionEdit;
using PNACCompetitionsDbFirst.Models.ViewModels.Results;

namespace PNACCompetitionsDbFirst.Controllers
{
  public class CompetitionsController : PNACController
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************


    #endregion


    #region *********************** Properties ***********************

    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************


    private void AssignModel(Competition competition, CompetitionEdit model)
    {
      competition.Venue = model.Venue;
      competition.Start = DateTime.Parse(model.StartDate + " " + model.StartTime);

      if (model.DayType == "m")
        competition.End = DateTime.Parse(model.EndDate + " " + model.EndTime);

      competition.DayType = model.DayType;

      competition.EnvironmentId = model.EnvironmentId;
    }


    private bool CanEdit(Competitor competitor)
    {
      /*
      bool canEdit = false;

      if (Competitor != null && (Competitor.CompetitorId == competitor.CompetitorId || Competitor.Admin))
        canEdit = true;

      return canEdit;
      */
      return false;
    }



    private bool CanEditCompetition(int competitionId)
    {
      bool canEdit = false;

      if (db.Competitions.Any(c => c.CompetitionId == competitionId))
      {
        if (IsAdmin)
          canEdit = true;
        else if (Competitor != null)
        {
          if (db.Entries.Any(e => e.CompetitionId == competitionId && e.CompetitorId == Competitor.CompetitorId && (e.IsTripCaptain || e.IsReferee)))
            canEdit = true;
        }
      }

      return canEdit;
    }


    private List<CompetitorCatch> Catches(Competition competition)
    {
      List<CompetitorCatch> results = new List<CompetitorCatch>();

      foreach (Entry entry in competition.Entries)
      {
        results.AddRange(Catches(entry));
      }

      return results;
    }


    private List<CompetitorCatch> Catches(Entry entry)
    {
      List<CompetitorCatch> results = new List<CompetitorCatch>();

      foreach (Catch @catch in entry.Catches)
      {
        results.Add(new CompetitorCatch() { CatchAndRelease = @catch.CatchAndRelease, Date = @catch.Date, CatchId = @catch.CatchId, CompetitorName = entry.Competitor.FriendlyName(), EntryId = entry.EntryId, FishName = @catch.Fish.Name, Length = @catch.Length, Number = @catch.Number, Weight = (float)@catch.Weight });
      }

      return results;
    }


    private List<CompetitorEntry> CompetitionEntries(Competition competition)
    {
      CompetitorEntry entrant;
      List<CompetitorEntry> entries = new List<CompetitorEntry>();

      foreach (Entry entry in competition.Entries.Where(e => e.CompetitionId == competition.CompetitionId))
      {
        entrant = new CompetitorEntry() { Name = entry.Competitor.FriendlyName(), CompetitorId = entry.CompetitorId, IsTripCaptain = entry.IsTripCaptain, IsReferee = entry.IsReferee };
        entries.Add(entrant);
      }

      entrant = new CompetitorEntry() { Name = "", CompetitorId = 0, IsTripCaptain = false, IsReferee = false };
      entries.Add(entrant);

      return entries;
    }


    private CompetitionCatches CompetitionResults(Competition competition)
    {
      CompetitionCatches results = new CompetitionCatches();
      results.CompetitonId = competition.CompetitionId;
      results.Catches = Catches(competition);
      results.ShowDay = competition.DayType == "m";

      return results;
    }


    public JsonResult Delete(int id)
    {
      var json = new { success = "false" };
      Competition competition = db.Competitions.Single(c => c.CompetitionId == id);

      if (CanEditCompetition(id))
      {
        db.Entries.RemoveRange(db.Entries.Where(e => e.CompetitionId == id));
        db.SaveChanges();

        db.Competitions.Remove(competition);
        db.SaveChanges();

        json = new { success = "true" };
      }

      return Json(json, JsonRequestBehavior.AllowGet);
    }


    [HttpPost]
    public JsonResult DeleteEntry(int competitorId, int competitionId)
    {
      var json = new { success = "false" };

      if (CanEditCompetition(competitionId))
      {
        if (db.Entries.Any(e => e.CompetitorId == competitorId && e.CompetitionId == competitionId))
        {
          db.Entries.RemoveRange(db.Entries.Where(e => e.CompetitorId == competitorId && e.CompetitionId == competitionId));
          db.SaveChanges();
        }
        json = new { success = "true" };
      }

      return Json(json, JsonRequestBehavior.AllowGet);
    }


    [Authorize]
    public ActionResult Edit(int id, int ? tabId)
    {
      Competition competition = db.Competitions.SingleOrDefault(c => c.CompetitionId == id);
      CompetitionEdit edit = new CompetitionEdit();

      if (CanEditCompetition(id))
      {
        edit.CompetitionId = competition.CompetitionId;
        edit.Venue = competition.Venue;
        edit.Begun = (DateTime.Now - competition.Start).TotalMinutes > 0;
        edit.StartDate = Format.DateOnly(competition.Start);
        edit.StartTime = Format.TimeOnly(competition.Start);
        edit.DayType = competition.DayType;

        edit.MemberNames = MakeNames(competition);

        if (competition.DayType == "m")
        {
          edit.EndDate = Format.DateOnly((DateTime)competition.End);
          edit.EndTime = Format.TimeOnly((DateTime)competition.End);
          edit.DayType = "m";
        }
        else
        {
          edit.EndDate = Format.DateOnly(competition.Start.AddDays(1));
          edit.EndTime = "5:00 PM";
          edit.DayType = "s";
        }

        edit.CompetitionEntries = CompetitionEntries(competition);
        edit.CompetitionCatches = CompetitionResults(competition);
        edit.Environments = Environments();
        edit.EnvironmentId = competition.EnvironmentId;

        if (tabId != null)
          edit.TabId = (TABS)tabId;
      }
      else
        throw new UnauthorizedAccessException();

      return View(edit);
    }


    [Authorize]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(CompetitionEdit model)
    {
      Competition competition = db.Competitions.SingleOrDefault(c => c.CompetitionId == model.CompetitionId);

      Validate(model);

      if (CanEditCompetition(model.CompetitionId) && ModelState.IsValid)
      {
        AssignModel(competition, model);

        db.SaveChanges();
        return RedirectToAction("Index");
      }
      else if (CanEditCompetition(model.CompetitionId) && !ModelState.IsValid)
      {
        model.MemberNames = MakeNames(competition);
        model.Environments = Environments();
        model.CompetitionEntries = CompetitionEntries(competition);
        model.CompetitionCatches = CompetitionResults(competition);

        return View(model);
      }
      else if (!IsAdmin)
        throw new UnauthorizedAccessException("");

      throw new Exception("Edit(CompetitionEdit model)");

    }


    public List<RadioValue> Environments()
    {
      List<RadioValue> environments = new List<RadioValue>();

      foreach (Entities.Environment environment in db.Environments.OrderBy(e => e.Order))
      {
        environments.Add(new RadioValue() { Description = environment.Name, Id = environment.EnvironmentId });
      }

      return environments;
    }


    public ActionResult Index()
    {
      IEnumerable<Competition> competition = db.Competitions.OrderBy(c => c.Name);
      CompetitionListItem competitionListItem;
      CompetitionIndex index = new CompetitionIndex();

      index.CompetitionListItems = new List<CompetitionListItem>();
      bool canEdit = IsAdmin;

      foreach (Competition competition_ in db.Competitions.OrderByDescending(c => c.Start).ThenBy(c => c.Venue))
      {
        competitionListItem = new CompetitionListItem()
        {
          CompetitionId = competition_.CompetitionId,
          Venue = competition_.Venue,
          Start = competition_.Start,
          CanEdit = canEdit,
          WeighIn = competition_.WeighInDescription()
        };

        if (competition_.DayType == "m")
          competitionListItem.End = (DateTime)competition_.End;

        index.CompetitionListItems.Add(competitionListItem);
      }

      if (Competitor != null)
        index.CanCreate = Competitor.Admin;

      return View(index);
    }


    protected string MakeNames(Competition competition)
    {
      string name, names = "";

      foreach (Competitor competitor in db.Competitors.OrderBy(c => c.LastName).ThenBy(c => c.FirstName))
      {
        if (!competition.Entries.Any(e => e.CompetitorId == competitor.CompetitorId))
        {
          if (names.Length != 0)
            names += ",\n ";

          name = competitor.FriendlyName().Replace("'", "\\'");

          names += "{value:" + competitor.CompetitorId + ", label:'" + name + "'}";
        }
      }

      return names;
    }


    [Authorize]
    public ActionResult New()
    {
      CompetitionEdit newCompetition = new CompetitionEdit();

      if (IsAdmin)
      {
        newCompetition.Venue = "";
        DateTime today = DateTime.Now;
        int saturday = 6;
        DateTime nextStaurday = today.AddDays(saturday - (int)today.DayOfWeek);

        newCompetition.StartDate = Format.DateOnly(nextStaurday);
        newCompetition.StartTime = "6:00am";

        newCompetition.EndDate = Format.DateOnly(nextStaurday.AddDays(1));
        newCompetition.EndTime = "5:00 PM";
        newCompetition.DayType = "s";

        newCompetition.Venue = "";

        newCompetition.EnvironmentId = db.Environments.Single(e => e.Name.ToLower().IndexOf("fresh") != -1).EnvironmentId;

        newCompetition.Environments = Environments();
      }
      else
        throw new UnauthorizedAccessException();

      return View(newCompetition);
    }


    [Authorize, HttpPost, ValidateAntiForgeryToken]
    public ActionResult New(CompetitionEdit model)
    {
      Competition competition = new Competition();
      Validate(model);

      if (IsAdmin && ModelState.IsValid)
      {
        AssignModel(competition, model);

        db.Competitions.Add(competition);
        db.SaveChanges();
        return RedirectToAction("edit", new { id = competition.CompetitionId });
      }
      else if (!IsAdmin)
        throw new UnauthorizedAccessException("");
      else
      {
        model.MemberNames = MakeNames(competition);
        model.Environments = Environments();
        model.CompetitionEntries = CompetitionEntries(competition);

        return View(model);
      }
    }


    public ActionResult Results(int id)
    {
      Competition competition = db.Competitions.Single(c => c.CompetitionId == id);
      ResultsIndex index = new ResultsIndex();

      index.LengthResults = competition.LengthResults(db.Catches.Where(c => c.Entry.CompetitionId == id));
      index.WeightResults = competition.WeightResults();

      return View(index);
    }


    [Authorize, HttpPost]
    public JsonResult SaveEntries(CompetitionEntries model)
    {
      if (CanEditCompetition(model.CompetitionId))
      {
        Entry entrant;

        //db.Entries.RemoveRange(db.Entries.Where(e => e.CompetitionId == model.CompetitionId));
        //db.SaveChanges();

        foreach (CompetitorEntry entry in model.Competitors)
        {
          if (db.Competitors.Any(c => c.CompetitorId == entry.CompetitorId) && !db.Entries.Any(e => e.CompetitionId == model.CompetitionId && e.CompetitorId == entry.CompetitorId))
          {
            entrant = new Entry() { CompetitionId = model.CompetitionId, CompetitorId = entry.CompetitorId, IsReferee = entry.IsReferee };

            if (model.TripCaptain == entry.CompetitorId)
              entrant.IsTripCaptain = true;

            db.Entries.Add(entrant);
          }
        }

        db.SaveChanges();
      }
      else
        throw new UnauthorizedAccessException("Entries");

      return Json(new { success = "Success" }, JsonRequestBehavior.AllowGet);
    }


    private void Validate(CompetitionEdit model)
    {
      DateTime startDate = DateTime.Parse(model.StartDate);

      if (model.DayType == "m")
      {
        DateTime endDate;

        endDate = DateTime.Parse(model.EndDate);

        if ((endDate - startDate).TotalHours < 24)
        {
          ModelState.AddModelError("End date", "The end date must be after the start date");
        }
        else if ((endDate - startDate).TotalDays > 7)
        {
          ModelState.AddModelError("End date", "The competition cannot be over 7 days long");
        }
      }
    }


    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}