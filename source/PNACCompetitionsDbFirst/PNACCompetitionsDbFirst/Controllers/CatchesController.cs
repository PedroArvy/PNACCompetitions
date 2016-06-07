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
      }
      else
        throw new UnauthorizedAccessException("New");

      return View(result);
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(CatchEdit result)
    {
      Catch @catch = db.Catches.Single(c => c.CatchId == result.CatchId);

      if (@catch.Entry.Competition.CanAddEntries(Competitor))
      {
        Validate(result);

        if (ModelState.IsValid)
        {
          Populate(result, @catch);
          db.SaveChanges();

          if(result.GoToNew)
            return RedirectToAction("New", "Catches", new { id = @catch.Entry.CompetitionId });
          else
            return RedirectToAction("Edit", "Competitions", new { id = @catch.Entry.CompetitionId, tabid = (int)CompetitionEdit.TABS.RESULTS });
        }
        else
        {
          Populate(result, @catch.Entry.Competition);
          return View(result);
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
      CatchEdit result = new CatchEdit();

      if (competition.CanAddEntries(Competitor))
      {
        Populate(result, competition);
      }
      else
        throw new UnauthorizedAccessException("New");

      return View(result);
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult New(CatchEdit result)
    {
      Competition competition = db.Competitions.Single(c => c.CompetitionId == result.CompetitionId);

      if (competition.CanAddEntries(Competitor))
      {
        Validate(result);
        Catch @catch = new Catch();

        if (ModelState.IsValid)
        {
          Populate(result, @catch);

          db.Catches.Add(@catch);
          db.SaveChanges();

          if (result.GoToNew)
            return RedirectToAction("New", "Catches", new { id = @catch.Entry.CompetitionId });
          else
            return RedirectToAction("Edit", "Competitions", new { id = competition.CompetitionId, tabid = (int)CompetitionEdit.TABS.RESULTS });
        }
        else
        {
          result.Entrants = Entrants(competition);
          result.Fish = Species(competition);
          result.Lengths = NumericalList(20, 200);
          result.Numbers = NumericalList(1, 50);

          return View(result);
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


    private void Populate(CatchEdit result, Competition competition)
    {
      result.CompetitionId = competition.CompetitionId;
      result.Entrants = Entrants(competition);
      result.Fish = Species(competition);
      result.Lengths = NumericalList(20, 200);
      result.Numbers = NumericalList(1, 50);
    }


    private void Populate(CatchEdit result, Catch @catch)
    {
      @catch.EntryId = result.EntrantId;
      @catch.FishId = result.FishId;
      @catch.Date = DateTime.Now;
      @catch.CatchAndRelease = result.CatchAndRelease.ToLower() == "yes" ? true : false;

      if (@catch.CatchAndRelease)
      {
        @catch.Number = 1;
        @catch.Weight = 0;
        @catch.Length = result.Length;
      }
      else
      {
        @catch.Number = (int)result.Quantity;
        @catch.Weight = result.Weight;

        if (@catch.Number == 1)
          @catch.Length = result.Length;
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


    private void Validate(CatchEdit result)
    {
      bool catchAndRelease = result.CatchAndRelease.ToLower() == "yes" ? true : false;

      if (catchAndRelease)
      {
        if (result.Length <= 0)
          ModelState.AddModelError("length", "You need to enter a length");
      }
      else
      {
        if (result.Quantity <= 0)
          ModelState.AddModelError("quantity", "You need to enter a quantity");

        if (result.Weight <= 0.1 || result.Weight > 200)
          ModelState.AddModelError("length", "You need to enter a weight between 0.1kg and 200kg");
      }
    }



    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}