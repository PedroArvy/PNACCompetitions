using Entities;
using PNACCompetitions.Entities;
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
      using (var db = new CompetitionDbContext())
      {
        Tests test = new Tests(db);
        test.Construction();
        test.Power();
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