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


    public ActionResult Edit(int id)
    {
      SeasonEdit model = new SeasonEdit();
      Season season = db.Seasons.Single(s => s.SeasonId == id);


      if (IsAdmin)
      {
        model.StartDate = season.Start.ToString(Format.DATE_FORMAT_CS);
        model.EndDate = season.End.ToString(Format.DATE_FORMAT_CS);
      }
      else
        throw new UnauthorizedAccessException("seasons edit");


      return View(model);
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