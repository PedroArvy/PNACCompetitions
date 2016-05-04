using Competitions.POCO;
using Competitions.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

    public static void Test(ICompetitionStore store)
    {

      Club club = new Club("Northern Suburbs Fly Fishing Club");
      store.Add(club);

      Season season = new Season(club, DateTime.Parse("5 September 2017"), DateTime.Parse("5 September 2018"));
      store.Add(season);
    }

    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}
