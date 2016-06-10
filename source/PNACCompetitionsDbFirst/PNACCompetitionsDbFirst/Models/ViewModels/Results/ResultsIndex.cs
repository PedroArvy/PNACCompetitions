using PNACCompetitionsDbFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Models.ViewModels.Results
{
  public class ResultsIndex
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public List<LengthResult> LengthResults { get; set; }
    public List<WeightResult> WeightResults { get; set; }
    public List<FishResult> FishResults { get; set; }

    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }

}