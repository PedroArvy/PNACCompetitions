using Competitions.Entities;
using Competitions.Tests;
using Microsoft.AspNet.Mvc;

namespace PNACCompetitions
{
  public class HomeController : Controller
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************

    private CompetitionDbContext _context;

    #endregion


    #region *********************** Properties ***********************
    #endregion


    #region *********************** Initialisation *******************

    public HomeController(CompetitionDbContext context)
    {
      _context = context;
    }


    #endregion


    #region *********************** Methods **************************


    public ViewResult Index()
    {
      return View();
    }


    public IActionResult Test()
    {
      Tests test = new Tests();

      test.SeasonClubAddition(_context);

      return RedirectToAction(nameof(Index));
    }


    #endregion


    #region *********************** Interfaces ***********************
    #endregion



  }
}
