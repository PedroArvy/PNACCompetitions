using Competitions.POCO;
using Competitions.Stores;
using Microsoft.Data.Entity;
using System.Collections.Generic;

namespace Competitions.Services
{
  public class SqlCompetitionData : ICompetitionData
  {

    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************

    private CompetitionDbContext _context;

    #endregion


    #region *********************** Properties ***********************
    #endregion


    #region *********************** Initialisation *******************

    public SqlCompetitionData(CompetitionDbContext context)
    {
      _context = context;


      //_context.SaveChanges();
    }

    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************

    public void Add(Club club)
    {
      _context.Clubs.Add(club);
      _context.SaveChanges();
    }


    public void Add(Season season)
    {
      _context.Seasons.Add(season);
      _context.SaveChanges();
    }


    public IEnumerable<Club> Clubs()
    {
      return _context.Clubs;
    }


    public void Delete(Club club)
    {
      _context.Clubs.Remove(club);
      _context.SaveChanges();
    }


    public void Delete(Season season)
    {
      _context.Seasons.Remove(season);
      _context.SaveChanges();
    }


    public IEnumerable<Season> Seasons()
    {
      return _context.Seasons;
    }


    #endregion



  }
}
