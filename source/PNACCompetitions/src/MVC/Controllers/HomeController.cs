using Competitions.Services;
using Competitions.Tests;
using Microsoft.AspNet.Mvc;

namespace PNACCompetitions
{
  public class HomeController : Controller
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************

    private ICompetitionData _ICompetitionData;

    #endregion


    #region *********************** Properties ***********************
    #endregion


    #region *********************** Initialisation *******************

    public HomeController(ICompetitionData iCompetitionData)
    {
      _ICompetitionData = iCompetitionData;
    }


    #endregion


    #region *********************** Methods **************************


    public ViewResult Index()
    {
      return View();
    }


    public IActionResult Test()
    {
      int x = 4;
      if (x == 4)
      {

      }


      Tests test = new Tests();

      test.SeasonClubAddition(_ICompetitionData);

      return RedirectToAction(nameof(Index));
    }


    #endregion


    #region *********************** Interfaces ***********************
    #endregion



  }
}
