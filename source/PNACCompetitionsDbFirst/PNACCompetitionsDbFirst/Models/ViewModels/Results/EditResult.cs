using PNACCompetitionsDbFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Models.ViewModels.Results
{
  public class EditResult
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public bool CatchAndRelease { get; set; }

    public int EntryId { get; set; }
    public List<Entry> Entries { get; set; }

    public int FishId { get; set; }
    public List<Fish> PossibleFish { get; set; }

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


