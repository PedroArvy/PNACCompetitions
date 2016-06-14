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

    public ActionResult Menu()
    {
      MenuViewModel menu = new MenuViewModel();

      if(Competitor != null && Competitor.AspNetUser != null)
        menu.IsAdmin = Competitor.Admin;

      return PartialView(menu);
    }


    public ActionResult Index()
    {
      List<LeaderBoardItem> items = db.LeaderBoardLength(db.Current());

      return View(items.OrderBy(i => i.Rank));
    }


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

    #endregion


    #region *********************** Interfaces ***********************
    #endregion


  }
}