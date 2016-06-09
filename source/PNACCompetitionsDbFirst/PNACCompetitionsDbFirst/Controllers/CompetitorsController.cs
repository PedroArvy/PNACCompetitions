using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using PNACCompetitionsDbFirst.Entities;
using PNACCompetitionsDbFirst.Models.ViewModels;
using PNACCompetitionsDbFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Security;
using static PNACCompetitionsDbFirst.Entities.Competition;

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


    private void AssignErrors(Competitor competitor, CompetitorEdit model)
    {
      if (string.IsNullOrWhiteSpace(model.Email) && (!string.IsNullOrWhiteSpace(model.Password) || !string.IsNullOrWhiteSpace(model.ConfirmPassword)))
        ModelState.AddModelError("Password", "You need to provide an email address to assign a password");

      if (!string.IsNullOrWhiteSpace(competitor.AspNetUserId) && string.IsNullOrWhiteSpace(model.Email))
        ModelState.AddModelError("Email", "You need to provide an email address");

      if (!string.IsNullOrWhiteSpace(model.Password) && model.Password != model.ConfirmPassword)
        ModelState.AddModelError("Password", "Password and confirm password do not match");
    }


    private void AssignModel(Competitor competitor, CompetitorEdit model)
    {
      competitor.FirstName = model.FirstName;
      competitor.NickName = model.NickName;
      competitor.LastName = model.LastName;
      competitor.Email = model.Email;

      if (competitor.AspNetUser != null)
        competitor.AspNetUser.Email = model.Email;

      competitor.Admin = model.Admin;

      if (model.ShowCompetitorType)
        competitor.CompetitorType = (int)model.CompetitorType;

      competitor.Gender = (int)model.Gender;

      competitor.Phone = model.Phone;
      competitor.Mobile = model.Mobile;

      competitor.Suburb = model.Suburb;

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


    public ActionResult Create(int id)
    {
      CompetitorCreate model = new CompetitorCreate();
      Competitor competitor = db.Competitors.Single(c => c.CompetitorId == id);

      model.Name = competitor.FriendlyName();
      model.CompetitorId = competitor.CompetitorId;

      return View(model);
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Create(CompetitorCreate model)
    {
      Competitor competitor = db.Competitors.Single(c => c.CompetitorId == model.CompetitorId);

      CreateErrors(competitor, model);

      if (ModelState.IsValid)
      {
        var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
        var result = await UserManager.CreateAsync(user, model.Password);

        if (result.Succeeded)
        {
          competitor.AspNetUserId = user.Id;
          db.SaveChanges();
          await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
          return RedirectToAction("Index", "Home");
        }

        return RedirectToAction("Index");
      }
      else
        return View(model);
    }


    private bool CreateErrors(Competitor competitor, CompetitorCreate model)
    {
      bool passed = false;

      if (!string.IsNullOrEmpty(model.Email.Trim()) && model.Email.Trim().Length >= 10 & competitor.Email.Length == 0)
        passed = true;

      else if (!string.IsNullOrEmpty(model.Email) && model.Email.Trim().Length >= 10 & model.Email == competitor.Email)
        passed = true;

      if (!passed)
      {
        if (!string.IsNullOrEmpty(model.Email.Trim()) && model.Email.Trim() != competitor.Email)
          ModelState.AddModelError("Email", "The email address does not match what you have supplied to the club");
      }

      return passed;
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

      return Json(new { success = success.ToString().ToLower() }, JsonRequestBehavior.AllowGet);
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

        if (competitor.AspNetUser != null && competitor.AspNetUser.Email != null)
          edit.Email = competitor.AspNetUser.Email;
        else
          edit.Email = competitor.Email;
       
        edit.Admin = competitor.Admin;
        edit.CompetitorType = competitor.CompetitorType;
        edit.Gender = competitor.Gender;
        edit.CompetitorId = competitor.CompetitorId;
        edit.FriendlyName = competitor.FriendlyName();
        edit.Hidden = competitor.Hide;
        edit.Phone = competitor.Phone;
        edit.Mobile = competitor.Mobile;
        edit.Suburb = competitor.Suburb;

        if (Competitor.Admin)
        {
          edit.ShowAdmin = true;
          edit.ShowHidden = true;
          edit.ShowCompetitorType = true;
        }
      }
      else
        throw new UnauthorizedAccessException();

      return View(edit);
    }


    [HttpPost]
    public async Task<ActionResult> Edit(CompetitorEdit model)
    {
      CompetitorEdit edit = new CompetitorEdit();
      Competitor competitor = db.Competitors.SingleOrDefault(c => c.CompetitorId == model.CompetitorId);

      AssignErrors(competitor, model);

      if (CanEdit(competitor) && ModelState.IsValid)
      {
        AssignModel(competitor, model);

        AspNetUser aspNetUser = db.AspNetUsers.SingleOrDefault(u => u.UserName == model.Email.Trim());

        if (aspNetUser == null)
        {
          var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
          var result = UserManager.CreateAsync(user, model.Password);
        }
        else
        {
          var user = await UserManager.FindByNameAsync(model.Email);

          UserManager.RemovePassword(user.Id);
          UserManager.AddPassword(user.Id, model.Password);
        }

        if(aspNetUser != null)
        {
          competitor.AspNetUser.Email = model.Email;
          competitor.AspNetUser.UserName = model.Email;
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
      CompetitorIndex model = new CompetitorIndex();

      model.CompetitorListItems = new List<CompetitorListItem>();

      IEnumerable<Competitor> competitors = null;

      if (IsAdmin)
        competitors = db.Competitors.OrderBy(c => c.LastName);
      else
        competitors = db.Competitors.Where(c => c.Hide == false).OrderBy(c => c.LastName);

      foreach (Competitor competitor in competitors)
      {
        competitorListItem = new CompetitorListItem() { Name = competitor.FriendlyName(), CompetitorId = competitor.CompetitorId, Hide = competitor.Hide, IsRegistered = !string.IsNullOrEmpty(competitor.AspNetUserId) };

        if (CanEdit(competitor))
          competitorListItem.CanEdit = true;

        if (IsAdmin)
          competitorListItem.IsAdmin = true;

        if (!string.IsNullOrEmpty(competitor.AspNetUserId))
          competitorListItem.CanCreatePassword = false;
        else if (AspNetUser == null)
          competitorListItem.CanCreatePassword = true;
        else if (AspNetUser != null && IsAdmin)
          competitorListItem.CanCreatePassword = true;
        else
          competitorListItem.CanCreatePassword = false;

        if (Competitor != null && !string.IsNullOrEmpty(Competitor.AspNetUserId) && Competitor.AspNetUserId == competitor.AspNetUserId)
          competitorListItem.IsLoggedIn = true;

        model.CompetitorListItems.Add(competitorListItem);
      }

      if (Competitor != null)
        model.CanCreate = Competitor.Admin;

      model.MemberNames = MakeNames();

      return View(model);
    }



    protected string MakeNames()
    {
      string name, names = "";

      foreach (Competitor competitor in db.Competitors.OrderBy(c => c.LastName).ThenBy(c => c.FirstName))
      {
        if (names.Length != 0)
          names += ",\n ";

        name = competitor.FriendlyName().Replace("'", "\\'");
        names += "{value:" + competitor.CompetitorId + ", label:'" + name + "'}";
      }

      return names;
    }


    public ActionResult Modified()
    {
      return View();
    }


    public ActionResult New()
    {
      CompetitorEdit edit = new CompetitorEdit();

      if (Competitor.Admin)
      {
        edit.ShowAdmin = true;
        edit.ShowCompetitorType = true;
        edit.CompetitorType = (int)COMPETITOR_TYPE.SENIOR;
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

      if (db.Competitors.Any(c => c.AspNetUser.Email.ToLower() == model.Email.ToLower() && model.Email.ToLower().Length > 0))
        ModelState.AddModelError("Email", "There is already a user with this email address");

      if (db.Competitors.Any(c => c.FirstName.ToLower() == model.FirstName.ToLower() && c.LastName.ToLower() == model.LastName.ToLower()))
      {
        ModelState.AddModelError(nameof(model.FirstName), "There is already a user with this name");
        ModelState.AddModelError(nameof(model.LastName), "There is already a user with this name");
      }

      if (Competitor.Admin && ModelState.IsValid)
      {
        AssignModel(competitor, model);

        if (!string.IsNullOrWhiteSpace(model.Password) && model.Password == model.ConfirmPassword)
        {
          var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
          var result = await UserManager.CreateAsync(user, model.Password);
        }

        AspNetUser aspNetUser = db.AspNetUsers.SingleOrDefault(a => a.Email == model.Email);

        if(aspNetUser != null)
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