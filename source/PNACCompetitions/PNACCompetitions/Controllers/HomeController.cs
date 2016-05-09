using PNACCompetitions.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PNACCompetitions.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
     // List<Score> leaderBoard = new List<Score>();

      using (var db = new PNACCompetitionsEntities())
      {
        //Tests test = new Tests(db);
        //test.Construction(false);
        //test.Power();

        foreach (Catch @catch in db.Catches)
        {
          //leaderBoard.Add(@catch.LeaderBoard());
        }
      }

      return View();
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
  }
}