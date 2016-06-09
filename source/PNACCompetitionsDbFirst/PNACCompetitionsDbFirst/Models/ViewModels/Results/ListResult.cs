using PNACCompetitionsDbFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Models.ViewModels.Results
{
  public class CompetitorResult
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public bool CatchAndRelease { get; set; }

    public int CatchId { get; set; }

    public DateTime Date { get; set; }

    public int EntryId { get; set; }
    public string CompetitorName { get; set; }

    public string FishName { get; set; }

    /// <summary>
    /// only if 1 fish and catch and release
    /// </summary>
    public int Length { get; set; }

    /// <summary>
    /// If catch and release don't show and set to 1
    /// </summary>
    public int Number { get; set; } = 1;

    /// <summary>
    /// kg
    /// </summary>
    public float Weight { get; set; }
    
    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion

  }
}


