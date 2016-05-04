using Competitions.POCO;
using Competitions.Stores;

namespace Competitions.Persistence
{
  public class SqlCompetitionData : ICompetitionStore
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
      _context.Season.Add(season);
      _context.SaveChanges();
    }


    #endregion



  }
}
