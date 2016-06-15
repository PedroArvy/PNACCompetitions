using PNACCompetitionsDbFirst.Entities;
using PNACCompetitionsDbFirst.Models.ViewModels;
using PNACCompetitionsDbFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PNACCompetitionsDbFirst.Controllers
{
  public class HomeController : PNACController
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************

    #endregion


    #region *********************** Properties ***********************
    #endregion


    #region *********************** Initialisation *******************

    public HomeController()
    {
    }

    #endregion


    #region *********************** Methods **************************


    public ActionResult About()
    {
      ViewBag.Message = "Your application description page.";

      return View();
    }


    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }


    public ActionResult Index()
    {
      List<LeaderBoardItem> length = db.LengthPoints(db.Current());
      List<LeaderBoardItem> weight = db.WeightPoints(db.Current());

      return View(length.OrderBy(i => i.Rank));
    }


    public ActionResult Menu()
    {
      MenuViewModel menu = new MenuViewModel();

      if(Competitor != null && Competitor.AspNetUser != null)
        menu.IsAdmin = Competitor.Admin;

      return PartialView(menu);
    }


    #endregion


    #region *********************** Interfaces ***********************
    #endregion


  }
}