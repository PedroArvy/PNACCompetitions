using PNACCompetitionsDbFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Models.ViewModels
{
  public class LeaderBoard
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public IEnumerable<LeaderBoardItem> Length { get; set; }

    public IEnumerable<LeaderBoardItem> WeightEstuary { get; set; }

    public IEnumerable<LeaderBoardItem> WeightFresh { get; set; }

    public IEnumerable<LeaderBoardItem> WeightSaltwater { get; set; }

    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}