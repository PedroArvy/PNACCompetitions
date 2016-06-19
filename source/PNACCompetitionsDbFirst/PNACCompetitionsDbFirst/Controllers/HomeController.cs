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
      LeaderBoard board = new LeaderBoard();

      board.Length = db.LengthPoints(db.Current()).OrderBy(p => p.Rank);

      board.WeightFresh = db.WeightPoints(db.Current(), Fish.ENVIRONMENT.FRESHWATER).OrderBy(p => p.Rank);
      board.WeightSaltwater = db.WeightPoints(db.Current(), Fish.ENVIRONMENT.SALTWATER).OrderBy(p => p.Rank);
      board.WeightEstuary = db.WeightPoints(db.Current(), Fish.ENVIRONMENT.ESTUARY).OrderBy(p => p.Rank);

      return View(board);
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