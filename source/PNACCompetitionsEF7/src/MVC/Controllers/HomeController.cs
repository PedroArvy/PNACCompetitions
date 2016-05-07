using Competitions.Entities;
using Competitions.Tests;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using System.Linq;

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
      Club club = _context.Clubs.First();
      Season season = club.Seasons.First();

      return View(_context.Catches.Where(c => c.Competition.SeasonId == season.SeasonId).Include(c => c.Fish).Include(c => c.Competitor));
    }


    public IActionResult Test()
    {
      Tests test = new Tests(_context);

      test.Power();
      test.Construction();

      return RedirectToAction(nameof(Index));
    }


    #endregion


    #region *********************** Interfaces ***********************
    #endregion



  }
}
