using Competitions.Entities;
using Competitions.Tests;
using Microsoft.AspNet.Mvc;
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
      return View();
    }


    public IActionResult Test()
    {
      int no = _context.Clubs.Where(c => c.Id == 1).Count();

      no = _context.Competitors.Count();

      no = _context.Competitors.Where(c => c.ClubId == 1).Count();


      Tests test = new Tests(_context);

      test.Construction();

      return RedirectToAction(nameof(Index));
    }


    #endregion


    #region *********************** Interfaces ***********************
    #endregion



  }
}
