using PNACCompetitionsDbFirst.Controllers;
using PNACCompetitionsDbFirst.Entities;
using PNACCompetitionsDbFirst.Models;
using PNACCompetitionsDbFirst.Models.ViewModels;
using PNACCompetitionsDbFirst.Models.ViewModels.Entries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

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


    private List<CompetitorEntry> CompetitionEntries(Competition competition)
    {
      CompetitorEntry entrant;
      List<CompetitorEntry> entries = new List<CompetitorEntry>();

      foreach (Entry entry in competition.Entries.Where(e => e.CompetitionId == competition.CompetitionId))
      {
        entrant = new CompetitorEntry() { Name = entry.Competitor.FriendlyName(), CompetitorId = entry.CompetitorId, IsTripCaptain = entry.IsTripCaptain, IsReferee = entry.IsReferee };
        entries.Add(entrant);
      }

      if(entries.Count == 0)
      {
        entrant = new CompetitorEntry() { Name = "", CompetitorId = 0, IsTripCaptain = false, IsReferee = false };
        entries.Add(entrant);
      }

      return entries;
    }


    public JsonResult DeleteEntry(int competitorId, int competitionId)
    {
      if (CanEditCompetition(competitionId) && db.Entries.Any(e => e.CompetitorId == competitorId && e.CompetitionId == competitionId))
      {
        db.Entries.Remove(db.Entries.Single(e => e.CompetitorId == competitorId && e.CompetitionId == competitionId));
        db.SaveChanges();
      }

      return Json(new { success = "true" }, JsonRequestBehavior.AllowGet);
    }


    public ActionResult Edit(int id)
    {
      Competition competition = db.Competitions.SingleOrDefault(c => c.CompetitionId == id);
      CompetitionEdit edit = new CompetitionEdit();

      if (CanEditCompetition(id))
      {
        edit.CompetitionId = competition.CompetitionId;
        edit.Venue = competition.Venue;
        edit.StartDate = Format.DateOnly(competition.Start);
        edit.StartTime = Format.TimeOnly(competition.Start);
        edit.DayType = competition.DayType;

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
      }
      else
        throw new UnauthorizedAccessException();

      return View(edit);
    }


    [HttpPost]
    public ActionResult Edit(CompetitionEdit model)
    {
      CompetitionEdit edit = new CompetitionEdit();
      Competition competition = db.Competitions.SingleOrDefault(c => c.CompetitionId == model.CompetitionId);

      if (CanEditCompetition(model.CompetitionId) && ModelState.IsValid)
      {
        AssignModel(competition, model);

        db.SaveChanges();
        return RedirectToAction("Index");
      }
      else if (CanEditCompetition(model.CompetitionId) && !ModelState.IsValid)
        return View(model);
      else if (!IsAdmin)
        throw new UnauthorizedAccessException("");

      return new EmptyResult();
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


    public ActionResult New()
    {
      CompetitionEdit edit = new CompetitionEdit();

      edit.DayType = "s";

      return View(edit);
    }


    [HttpPost]
    [AllowAnonymous]
    [ValidateAntiForgeryToken]
    public ActionResult New(CompetitionEdit model)
    {
      CompetitionEdit edit = new CompetitionEdit();
      Competition competition = new Competition();

      if (IsAdmin && ModelState.IsValid)
      {
        AssignModel(competition, model);

        //db.Competition.Add(competition);
        db.SaveChanges();
        return RedirectToAction("Index");
      }
      else if (IsAdmin && !ModelState.IsValid)
        return View(model);
      else if (!IsAdmin)
        throw new UnauthorizedAccessException("");

      return new EmptyResult();
    }


    public ActionResult New1(CompetitionEntries model)
    {
      return null;
    }


    [HttpPost]
    public JsonResult SaveEntries(CompetitionEntries model)
    {
      if (CanEditCompetition(model.CompetitionId))
      {
        Entry entrant;

        db.Entries.RemoveRange(db.Entries.Where(e => e.CompetitionId == model.CompetitionId));
        db.SaveChanges();

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




    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}