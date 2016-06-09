using PNACCompetitionsDbFirst.Controllers;
using PNACCompetitionsDbFirst.Entities;
using PNACCompetitionsDbFirst.Models;
using PNACCompetitionsDbFirst.Models.ViewModels;
using PNACCompetitionsDbFirst.Models.ViewModels.Components;
using PNACCompetitionsDbFirst.Models.ViewModels.Entries;
using PNACCompetitionsDbFirst.Models.ViewModels.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace PNACCompetitionsDbFirst.Controllers
{
  public class CatchesController : PNACController
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


    [Authorize]
    public JsonResult Delete(int id)
    {
      bool success = false;
      Catch @catch = db.Catches.Single(s => s.CatchId == id);

      if (IsAdmin)
      {
        if(@catch != null)
        {
          db.Catches.Remove(@catch);
          db.SaveChanges();
        }

        success = true;
      }
      else
      {
        throw new UnauthorizedAccessException();
      }

      return Json(new { success = success.ToString().ToLower() }, JsonRequestBehavior.AllowGet);
    }



    public ActionResult Edit(int id)
    {
      Catch @catch = db.Catches.Single(c => c.CatchId == id);
      CatchEdit result = new CatchEdit();

      if (@catch.Entry.Competition.CanAddEntries(Competitor))
      {
        Populate(result, @catch.Entry.Competition);

        result.CatchId = @catch.CatchId;
        result.EntrantId = @catch.EntryId;
        result.FishId = @catch.FishId;
        result.Length = @catch.Length;
        result.Quantity = @catch.Number;
        result.Weight = @catch.Weight;
        result.CatchAndRelease = @catch.CatchAndRelease == true ? "Yes" : "No";
        result.Cleaned = @catch.Cleaned;
      }
      else
        throw new UnauthorizedAccessException("New");

      return View(result);
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(CatchEdit catchEdit)
    {
      Catch @catch = db.Catches.Single(c => c.CatchId == catchEdit.CatchId);

      if (@catch.Entry.Competition.CanAddEntries(Competitor))
      {
        Validate(catchEdit);

        if (ModelState.IsValid)
        {
          Populate(catchEdit, @catch);
          db.SaveChanges();

          if(catchEdit.GoToNew)
            return RedirectToAction("New", "Catches", new { id = @catch.Entry.CompetitionId });
          else
            return RedirectToAction("Edit", "Competitions", new { id = @catch.Entry.CompetitionId, tabid = (int)CompetitionEdit.TABS.RESULTS });
        }
        else
        {
          Populate(catchEdit, @catch.Entry.Competition);
          return View(catchEdit);
        }
      }
      else
        throw new UnauthorizedAccessException("New");
    }


    private List<SelectListItem> Entrants(Competition competition)
    {
      return competition.Entries.Select(entry => new SelectListItem { Text = entry.Competitor.FriendlyName(), Value = entry.EntryId.ToString() }).OrderBy(m => m.Text).ToList();
    }


    public ActionResult New(int id)
    {
      Competition competition = db.Competitions.Single(c => c.CompetitionId == id);
      CatchEdit @catch = new CatchEdit();

      if (competition.CanAddEntries(Competitor))
      {
        Populate(@catch, competition);
        @catch.Cleaned = true;
      }
      else
        throw new UnauthorizedAccessException("New");

      return View(@catch);
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult New(CatchEdit catchEdit)
    {
      Competition competition = db.Competitions.Single(c => c.CompetitionId == catchEdit.CompetitionId);

      if (competition.CanAddEntries(Competitor))
      {
        Validate(catchEdit);
        Catch @catch = new Catch();

        if (ModelState.IsValid)
        {
          Populate(catchEdit, @catch);

          db.Catches.Add(@catch);
          db.SaveChanges();

          if (catchEdit.GoToNew)
            return RedirectToAction("New", "Catches", new { id = @catch.Entry.CompetitionId });
          else
            return RedirectToAction("Edit", "Competitions", new { id = competition.CompetitionId, tabid = (int)CompetitionEdit.TABS.RESULTS });
        }
        else
        {
          catchEdit.Entrants = Entrants(competition);
          catchEdit.Fish = Species(competition);
          catchEdit.Lengths = NumericalList(20, 200);
          catchEdit.Numbers = NumericalList(1, 50);

          return View(catchEdit);
        }
      }
      else
        throw new UnauthorizedAccessException("New");
    }


    private List<SelectListItem> NumericalList(int min, int max)
    {
      SelectListItem item;
      List<SelectListItem> items = new List<SelectListItem>();

      for (int i = min; i <= max; i++)
      {
        item = new SelectListItem() { Text = i.ToString(), Value = i.ToString() };
        items.Add(item);
      }

      return items;
    }


    private void Populate(CatchEdit catchEdit, Competition competition)
    {
      catchEdit.CompetitionId = competition.CompetitionId;
      catchEdit.Entrants = Entrants(competition);
      catchEdit.Fish = Species(competition);
      catchEdit.Lengths = NumericalList(20, 200);
      catchEdit.Numbers = NumericalList(1, 50);
    }


    private void Populate(CatchEdit catchEdit, Catch @catch)
    {
      @catch.EntryId = catchEdit.EntrantId;
      @catch.FishId = catchEdit.FishId;
      @catch.Date = DateTime.Now;
      @catch.CatchAndRelease = catchEdit.CatchAndRelease.ToLower() == "yes" ? true : false;
      @catch.Cleaned = catchEdit.Cleaned;

      if (@catch.CatchAndRelease)
      {
        @catch.Number = 1;
        @catch.Weight = 0;
        @catch.Length = catchEdit.Length;
      }
      else
      {
        @catch.Number = (int)catchEdit.Quantity;
        @catch.Weight = catchEdit.Weight;

        if (@catch.Number == 1)
          @catch.Length = catchEdit.Length;
      }
    }


    private IEnumerable<SelectListItem> Species(Competition competition)
    {
      List<SelectListItem> items = new List<SelectListItem>();

      foreach (Fish fish in db.Fish)
      {
        if (fish.HasEnvironment(competition.Environment))
          items.Add(new SelectListItem { Value = fish.FishId.ToString(), Text = fish.Name });
      }

      return items.OrderBy(m => m.Text);
    }


    private void Validate(CatchEdit catchEdit)
    {
      bool catchAndRelease = catchEdit.CatchAndRelease.ToLower() == "yes" ? true : false;

      if (catchAndRelease)
      {
        if (catchEdit.Length <= 0)
          ModelState.AddModelError("length", "You need to enter a length");
      }
      else
      {
        if (catchEdit.Quantity <= 0)
          ModelState.AddModelError("quantity", "You need to enter a quantity");

        if (catchEdit.Weight <= 0.1 || catchEdit.Weight > 200)
          ModelState.AddModelError("length", "You need to enter a weight between 0.1kg and 200kg");
      }
    }

    #endregion


    #region *********************** Interfaces ***********************
    #endregion

  }
}