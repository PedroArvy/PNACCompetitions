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
  public class SeasonsController : PNACController
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
      Season season = db.Seasons.Single(s => s.SeasonId == id);

      if (IsAdmin)
      {
        db.Seasons.Remove(season);
        db.SaveChanges();
        success = true;
      }
      else
      {
        throw new UnauthorizedAccessException();
      }

      return Json(new { success = success.ToString().ToLower() }, JsonRequestBehavior.AllowGet);
    }


    public ActionResult New()
    {
      SeasonEdit model = new SeasonEdit();

      if (IsAdmin)
      {
        model.SeasonId = 0;
        model.StartDate = DateTime.Now.ToString(Format.DATE_FORMAT_CS);
        model.EndDate = DateTime.Now.AddDays(365).ToString(Format.DATE_FORMAT_CS);
      }
      else
        throw new UnauthorizedAccessException("seasons new");


      return View(model);
    }


    [HttpPost]
    public ActionResult New(SeasonEdit model)
    {
      if (IsAdmin)
      {
        Season season = new Season();

        season.Start = Convert.ToDateTime(model.StartDate + " 0:00am");
        season.End = Convert.ToDateTime(model.EndDate + " 11:59pm");
        season.ClubId = db.Clubs.First().ClubId;

        if ((season.End - season.Start).TotalDays <= 90)
          ModelState.AddModelError("EndDate", "The end date must be 90 days after the start date");

        if (ModelState.IsValid)
        {
          db.Seasons.Add(season);
          db.SaveChanges();
          return RedirectToAction("Index");
        }
        else
        {
          return View(model);
        }
      }
      else
        throw new UnauthorizedAccessException("seasons new");
    }


    public ActionResult Edit(int id)
    {
      SeasonEdit model = new SeasonEdit();
      Season season = db.Seasons.Single(s => s.SeasonId == id);

      if (IsAdmin)
      {
        model.SeasonId = id;
        model.StartDate = season.Start.ToString(Format.DATE_FORMAT_CS);
        model.EndDate = season.End.ToString(Format.DATE_FORMAT_CS);
      }
      else
        throw new UnauthorizedAccessException("seasons edit");


      return View(model);
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(SeasonEdit model)
    {
      Season season = db.Seasons.Single(s => s.SeasonId == model.SeasonId);

      if (IsAdmin)
      {
        season.Start = Convert.ToDateTime(model.StartDate + " 0:00am");
        season.End = Convert.ToDateTime(model.EndDate + " 11:59pm");

        if ((season.End - season.Start).TotalDays <= 90)
          ModelState.AddModelError("EndDate", "The end date must be 90 days after the start date");

        if(ModelState.IsValid)
        {
          db.SaveChanges();
          return RedirectToAction("Index");
        }
        else
        {
          return View(model);
        }
      }
      else
        throw new UnauthorizedAccessException("seasons edit");
    }


    public ActionResult Index()
    {
      SeasonsIndex model = new SeasonsIndex();
      model.Seasons = db.Seasons;
      model.CanEdit = IsAdmin;

      return View(model);
    }


    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}