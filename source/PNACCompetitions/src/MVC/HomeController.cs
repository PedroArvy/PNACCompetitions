using Competitions.Stores;
using Competitions.Tests;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PNACCompetitions
{
  public class HomeController : Controller
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************

    private ICompetitionStore _ICompetitionStore;

    #endregion


    #region *********************** Properties ***********************
    #endregion


    #region *********************** Initialisation *******************


    public HomeController(ICompetitionStore iCompetitionStore)
    {
      _ICompetitionStore = iCompetitionStore;
    }


    #endregion


    #region *********************** Methods **************************


    public ActionResult Index()
    {
      Tests.Test(_ICompetitionStore);

      return View();
    }


    #endregion


    #region *********************** Interfaces ***********************
    #endregion



  }
}
