using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PNACCompetitions.Entities
{
  public class Manager
  {
    #region *********************** Constants ************************


    #endregion


    #region *********************** Fields ***************************

    #endregion


    #region *********************** Properties ***********************
    #endregion


    #region *********************** Initialisation *******************



    #endregion


    #region *********************** Methods **************************


    public static IEnumerable<Catch> Catches(CompetitionDbContext context, Competition competition)
    {
      return context.Catches.Where(c => c.Entry.CompetitionId == competition.CompetitionId);
    }


    public static Competition Get(CompetitionDbContext context, Club club, DateTime date)
    {
      Competition competition = null;

      Season season = Manager.GetSeason(context, club, date);

      competition = context.Competitions.SingleOrDefault(c => c.SeasonId == season.SeasonId && c.Start <= date && date <= c.End);

      return competition;
    }


    public static Season GetSeason(CompetitionDbContext context, Club club, DateTime date)
    {
      Season season = null;

      season = context.Seasons.SingleOrDefault(s => s.ClubId == club.ClubId && s.Start <= date && date <= s.End);

      return season;
    }


    public static Season Get(CompetitionDbContext context, Club club, DateTime start, DateTime end)
    {
      Season season = null;

      season = context.Seasons.SingleOrDefault(s => s.ClubId == club.ClubId && s.Start <= start && end <= s.End);

      return season;
    }

    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}
