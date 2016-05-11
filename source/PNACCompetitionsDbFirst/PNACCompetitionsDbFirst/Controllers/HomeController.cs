using PNACCompetitionsDbFirst.Entities;
using PNACCompetitionsDbFirst.Entities.ViewModels;
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
      List<LeaderBoardLineItem> items = new List<LeaderBoardLineItem>();

      LeaderBoardLineItem item;

      foreach (Catch @catch in db.Catches)
      {
        item = @catch.LeaderBoardLineItem();
        items.Add(item);
      }

      int count = 1;
      foreach (LeaderBoardLineItem item_ in items.OrderBy(i => i.TrialPoints))
      {
        item_.Order = count;
        count++;
      }

      return View(items.OrderBy(i => i.Order));
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