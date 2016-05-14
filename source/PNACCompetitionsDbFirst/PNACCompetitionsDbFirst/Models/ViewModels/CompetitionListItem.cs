using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Models.ViewModels
{
  public class CompetitionListItem
  {

    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public int CompetitionId { get; set; }

    public bool CanEdit { get; set; }

    public DateTime End { get; set; }

    public bool SingleDay { get; set; }

    public DateTime Start { get; set; }

    public string Venue { get; set; }

    public string WeighIn { get; set; }

    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}