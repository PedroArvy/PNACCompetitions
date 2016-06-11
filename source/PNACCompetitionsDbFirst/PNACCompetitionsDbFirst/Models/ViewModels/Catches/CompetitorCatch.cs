using PNACCompetitionsDbFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Models.ViewModels.Catches
{
  public class CompetitorCatch
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public int CatchId { get; set; }

    public DateTime Date { get; set; }

    public string CompetitorName { get; set; }

    public string FishName { get; set; }

    public string Length { get; set; }

    public string LengthFormula { get; set; }

    public int Points { get; set; }

    public string Weight { get; set; }
    
    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion

  }
}


