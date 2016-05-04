using Competitions.POCO;
using Competitions.Services;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Competitions.Tests
{
  public class Tests
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

    public void SeasonClubAddition(ICompetitionData data)
    {

      Club club = new Club("Northern Suburbs Fly Fishing Club");
      data.Add(club);
      int clubId = club.Id;

      Season season1 = new Season(club, DateTime.Parse("5 September 2016"), DateTime.Parse("5 September 2017"));
      data.Add(season1);
      int season1Id = season1.Id;

      Season season2 = new Season(club, DateTime.Parse("5 September 2017"), DateTime.Parse("5 September 2018"));
      data.Add(season2);
      int season2Id = season2.Id;

      if(data.Seasons().Where(s => s.ClubId == clubId).Count() != 2)
        throw new Exception("SeasonClubAddition 1");

      if (data.Clubs().Where(c => c.Id == clubId).Count() != 1)
        throw new Exception("SeasonClubAddition 1");

      if (data.Clubs().Single(c => c.Id == clubId).Seasons.Count() != 2)
        throw new Exception("SeasonClubAddition 2");

      data.Delete(club);

      if (data.Clubs().SingleOrDefault(s => s.Id == clubId) != null)
        throw new Exception("SeasonClubAddition 3");

      if (data.Seasons().SingleOrDefault(s => s.Id == season1Id) != null)
        throw new Exception("SeasonClubAddition 4");

      if (data.Seasons().SingleOrDefault(s => s.Id == season2Id) != null)
        throw new Exception("SeasonClubAddition 5");
    }

    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}
