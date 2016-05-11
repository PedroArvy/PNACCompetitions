using PNACCompetitionsDbFirst.Controllers;
using PNACCompetitionsDbFirst.Entities;
using PNACCompetitionsDbFirst.Entities.ViewModels;
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

    private void AssignModel(Competitor competitor, FishEdit model)
    {
      /*
      competitor.FirstName = model.FirstName;
      competitor.NickName = model.NickName;
      competitor.LastName = model.LastName;

      if (competitor.AspNetUser != null)
        competitor.AspNetUser.Email = model.Email;

      competitor.Admin = model.Admin;

      if (model.ShowCompetitorType)
        competitor.CompetitorType = (int)model.CompetitorType;

      competitor.Gender = (int)model.Gender;

      if (competitor != null && competitor.Admin)
      {
        competitor.Admin = model.Admin;
      }
      */
    }


    private bool CanEdit(Competitor competitor)
    {
      bool canEdit = false;

      if (Competitor != null && (Competitor.CompetitorId == competitor.CompetitorId || Competitor.Admin))
        canEdit = true;

      return canEdit;
    }


    public ActionResult Edit(int id)
    {
      Fish fish = db.Fish.SingleOrDefault(c => c.FishId == id);
      FishEdit edit = new FishEdit();

      if (Competitor.Admin)
      {
        edit.Name = fish.Name;
        edit.Minimum = fish.Minimum;
        edit.Maximum = fish.Maximum;
        edit.Difficulty = fish.Difficulty;
      }
      else
        throw new NotImplementedException();

      return View(edit);
    }


    [HttpPost]
    public ActionResult Edit(CompetitorEdit model)
    {
      /*
      CompetitorEdit edit = new CompetitorEdit();
      Competitor competitor = db.Competitors.SingleOrDefault(c => c.CompetitorId == model.CompetitorId);

      if (CanEdit(competitor) && ModelState.IsValid)
      {
        AssignModel(competitor, model);

        if (!string.IsNullOrWhiteSpace(model.Password) && model.Password == model.ConfirmPassword)
        {
          UserManager<IdentityUser> userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>());

          userManager.RemovePassword(competitor.AspNetUser.Id);
          userManager.AddPassword(competitor.AspNetUser.Id, model.Password);
        }

        db.SaveChanges();
        return RedirectToAction("Index");
      }
      else if (CanEdit(competitor) && !ModelState.IsValid)
        return View(model);
      else if (!CanEdit(competitor))
        throw new UnauthorizedAccessException("");
        */
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
      /*
      CompetitorEdit edit = new CompetitorEdit();

      if (Competitor.Admin)
      {
        edit.ShowAdmin = true;
        edit.ShowCompetitorType = true;
      }

      return View(edit);
      */
      return null;
    }


    [HttpPost]
    [AllowAnonymous]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> New(CompetitorEdit model)
    {
      /*
      CompetitorEdit edit = new CompetitorEdit();
      Competitor competitor = new Competitor();

      if (Competitor.Admin && ModelState.IsValid)
      {
        AssignModel(competitor, model);

        if (!string.IsNullOrWhiteSpace(model.Password) && model.Password == model.ConfirmPassword)
        {
          var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
          var result = await UserManager.CreateAsync(user, model.Password);
        }

        AspNetUser aspNetUser = db.AspNetUsers.Single(a => a.Email == model.Email);
        competitor.AspNetUser = aspNetUser;


        competitor.ClubId = db.Clubs.First().ClubId;

        db.Competitors.Add(competitor);
        db.SaveChanges();
        return RedirectToAction("Index");
      }
      else if (CanEdit(competitor) && !ModelState.IsValid)
        return View(model);
      else if (!CanEdit(competitor))
        throw new UnauthorizedAccessException("");

  */
      return new EmptyResult();

    }


    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}