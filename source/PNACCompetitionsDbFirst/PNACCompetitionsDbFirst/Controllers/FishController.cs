using PNACCompetitionsDbFirst.Controllers;
using PNACCompetitionsDbFirst.Entities;
using PNACCompetitionsDbFirst.Models;
using PNACCompetitionsDbFirst.Models.ViewModels;
using PNACCompetitionsDbFirst.Models.ViewModels.Caught;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PNACCompetitionsDbFirst.Controllers
{
  public class FishController : PNACController
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

    private void AssignModel(Fish fish, FishEdit model)
    {
      fish.Name = model.Name;
      fish.Minimum = model.Minimum;
      fish.Maximum = model.Maximum;
      fish.Difficulty = model.Difficulty;

      fish.Environments.ToList().RemoveRange(0, fish.Environments.Count());

      if (model.EnvironmentFreshwater)
        fish.Environments.Add(db.Environments.Single(e => e.EnvironmentId == (int)Fish.ENVIRONMENT.FRESHWATER));

      if (model.EnvironmentEstuary)
        fish.Environments.Add(db.Environments.Single(e => e.EnvironmentId == (int)Fish.ENVIRONMENT.ESTUARY));

      if (model.EnvironmentSaltwater)
        fish.Environments.Add(db.Environments.Single(e => e.EnvironmentId == (int)Fish.ENVIRONMENT.SALTWATER));
    }


    private bool CanEdit(Competitor competitor)
    {
      bool canEdit = false;

      if (Competitor != null && (Competitor.CompetitorId == competitor.CompetitorId || Competitor.Admin))
        canEdit = true;

      return canEdit;
    }


    public ActionResult Caught(int catchId)
    {
      Catch theCatch = db.Catches.Single(c => c.CatchId == catchId);
      PNACCompetitionsDbFirst.Models.ViewModels.Caught.Index index = new Index();
      DateTime end = theCatch.Entry.Competition.EndDateTime();

      FishCaught caught;
      index.Species = theCatch.Fish.Name;

      index.Title = Format.TitleCase(theCatch.Fish.Name + " Caught Before " + end.ToString("d MMMM yyyy"));

      foreach (Catch @catch in db.Catches.Where(c => c.FishId == theCatch.FishId && c.Date <= end))
      {
        caught = new FishCaught() { CompetitorName = @catch.Entry.Competitor.FriendlyName(), Competition = @catch.Entry.Competition.Venue, Date = @catch.Date, Length = @catch.LengthForPoints() };

        if (@catch.Number == 1)
          caught.Weight = @catch.Weight;
        else
          caught.Weight = @catch.Heaviest;

        if(caught.Length != 0 && caught.Weight != 0)
          index.Caught.Add(caught);
      }

      return View(index);
    }


    public ActionResult Edit(int id)
    {
      Fish fish = db.Fish.SingleOrDefault(c => c.FishId == id);
      FishEdit edit = new FishEdit();

      if (Competitor.Admin)
      {
        edit.FishId = fish.FishId;
        edit.Name = fish.Name;
        edit.Minimum = fish.Minimum;
        edit.Maximum = fish.Maximum;
        edit.Difficulty = fish.Difficulty;

        edit.EnvironmentFreshwater = fish.Environments.Any(e => e.EnvironmentId == (int)Fish.ENVIRONMENT.FRESHWATER);
        edit.EnvironmentEstuary = fish.Environments.Any(e => e.EnvironmentId == (int)Fish.ENVIRONMENT.ESTUARY);
        edit.EnvironmentSaltwater = fish.Environments.Any(e => e.EnvironmentId == (int)Fish.ENVIRONMENT.SALTWATER);

      }
      else
        throw new NotImplementedException();

      return View(edit);
    }


    [HttpPost]
    public ActionResult Edit(FishEdit model)
    {
      
      FishEdit edit = new FishEdit();
      Fish fish = db.Fish.SingleOrDefault(c => c.FishId == model.FishId);

      if (IsAdmin && ModelState.IsValid)
      {
        AssignModel(fish, model);

        db.SaveChanges();
        return RedirectToAction("Index");
      }
      else if (IsAdmin && !ModelState.IsValid)
        return View(model);
      else if (!IsAdmin)
        throw new UnauthorizedAccessException("");
        
      return new EmptyResult();
    }


    public ActionResult Index()
    {
      IEnumerable<Fish> fish = db.Fish.OrderBy(c => c.Name);
      FishListItem fishListItem;
      FishIndex index = new FishIndex();

      index.FishListItems = new List<FishListItem>();

      foreach (Fish fish_ in db.Fish.OrderBy(c => c.Name))
      {
        fishListItem = new FishListItem() { FishId = fish_.FishId, Name = fish_.Name, Difficulty = fish_.Difficulty, Maximum = fish_.Maximum, Minimum = fish_.Minimum };

        index.FishListItems.Add(fishListItem);
      }

      if (Competitor != null)
        index.CanCreate = Competitor.Admin;

      return View(index);
    }


    public ActionResult New()
    {
      FishEdit edit = new FishEdit();
      return View(edit);
    }


    [HttpPost]
    [AllowAnonymous]
    [ValidateAntiForgeryToken]
    public ActionResult New(FishEdit model)
    {
      FishEdit edit = new FishEdit();
      Fish fish = new Fish();

      if (IsAdmin && ModelState.IsValid)
      {
        AssignModel(fish, model);

        db.Fish.Add(fish);
        db.SaveChanges();
        return RedirectToAction("Index");
      }
      else if (IsAdmin && !ModelState.IsValid)
        return View(model);
      else if (!IsAdmin)
        throw new UnauthorizedAccessException("");

      return new EmptyResult();
    }


    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}