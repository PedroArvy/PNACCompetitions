using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Models.ViewModels.Caught
{
  public class FishCaught
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public string Competition { get; set; }

    public string CompetitorName { get; set; }

    public DateTime Date { get; set; }

    public int Length { get; set; }

    public double Weight { get; set; }

    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}