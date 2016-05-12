using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using PNACCompetitionsDbFirst.Entities;
using PNACCompetitionsDbFirst.Entities.ViewModels;
using PNACCompetitionsDbFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PNACCompetitionsDbFirst.Controllers
{
  public class CompetitorsController : PNACController
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


    private void AssignModel(Competitor competitor, CompetitorEdit model)
    {
      competitor.FirstName = model.FirstName;
      competitor.NickName = model.NickName;
      competitor.LastName = model.LastName;

      if (competitor.AspNetUser != null)
        competitor.AspNetUser.Email = model.Email;

      competitor.Admin = model.Admin;

      if (model.ShowCompetitorType)
        competitor.CompetitorType = (int)model.CompetitorType;

      competitor.Gender = (int)model.Gender;

      if (model.ShowHidden)
        competitor.Hide = model.Hidden;

      if (competitor != null && competitor.Admin)
      {
        competitor.Admin = model.Admin;
      }
    }


    private bool CanEdit(Competitor competitor)
    {
      bool canEdit = false;

      if (Competitor != null && (Competitor.CompetitorId == competitor.CompetitorId || Competitor.Admin))
        canEdit = true;

      return canEdit;
    }

    [Authorize]
    public JsonResult Delete(int id)
    {
      bool success = false;
      Competitor competitor = db.Competitors.SingleOrDefault(c => c.CompetitorId == id);

      if (Competitor.Admin || (Competitor.CompetitorId == competitor.CompetitorId))
      {
        if (db.Catches.Any(c => c.Entry.CompetitorId == id))
          competitor.Hide = true;
        else
          db.Competitors.Remove(competitor);

        success = true;
        db.SaveChanges();
      }
      else
      {
        success = false;
      }


      return Json(new { success = success.ToString().ToString().ToLower() }, JsonRequestBehavior.AllowGet);
    }


    public ActionResult Edit(int id)
    {
      Competitor competitor = db.Competitors.SingleOrDefault(c => c.CompetitorId == id);
      CompetitorEdit edit = new CompetitorEdit();

      if (CanEdit(competitor))
      {
        edit.FirstName = competitor.FirstName;
        edit.NickName = competitor.NickName;
        edit.LastName = competitor.LastName;

        if(competitor.AspNetUser != null && competitor.AspNetUser.Email != null)
          edit.Email = competitor.AspNetUser.Email;

        edit.Admin = competitor.Admin;
        edit.CompetitorType = competitor.CompetitorType;
        edit.Gender = competitor.Gender;
        edit.CompetitorId = competitor.CompetitorId;
        edit.FriendlyName = competitor.FriendlyName();
        edit.Hidden = competitor.Hide;

        if (Competitor.Admin)
        {
          edit.ShowAdmin = true;
          edit.ShowHidden = true;
          edit.ShowCompetitorType = true;
        }
      }
      else
        throw new NotImplementedException();

      return View(edit);
    }


    [HttpPost]
    public ActionResult Edit(CompetitorEdit model)
    {
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

      return new EmptyResult();
    }


    public ActionResult Index()
    {
      CompetitorListItem competitorListItem;
      CompetitorIndex index = new CompetitorIndex();

      index.CompetitorListItems = new List<CompetitorListItem>();

      IEnumerable<Competitor> competitors = null;

      if (Competitor.Admin)
        competitors = db.Competitors.OrderBy(c => c.LastName);
      else
        competitors = db.Competitors.Where(c => c.Hide == false).OrderBy(c => c.LastName);


      foreach (Competitor competitor in competitors)
      {
        competitorListItem = new CompetitorListItem() { Name = competitor.FriendlyName(), CompetitorId = competitor.CompetitorId, Hide = competitor.Hide };

        if (CanEdit(competitor))
          competitorListItem.CanEdit = true;

        index.CompetitorListItems.Add(competitorListItem);
      }

      if(Competitor != null)
        index.CanCreate = Competitor.Admin;

      return View(index);
    }


    public ActionResult New()
    {
      CompetitorEdit edit = new CompetitorEdit();

      if (Competitor.Admin)
      {
        edit.ShowAdmin = true;
        edit.ShowCompetitorType = true;
      }

      return View(edit);
    }


    [HttpPost]
    [AllowAnonymous]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> New(CompetitorEdit model)
    {
      CompetitorEdit edit = new CompetitorEdit();
      Competitor competitor = new Competitor();

      if (db.Competitors.Any(c => c.AspNetUser.Email.ToLower() == model.Email.ToLower()))
        ModelState.AddModelError("Email", "There is already a user with this email address");

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

      return new EmptyResult();
    }


    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}