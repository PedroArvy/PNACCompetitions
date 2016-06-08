using PNACCompetitionsDbFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Models.ViewModels
{
  public class SeasonsIndex
  {
    #region *********************** Constants ************************

    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************


    public bool CanEdit { get; set; }

    public IQueryable<Season> Seasons { get; set; }


    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}