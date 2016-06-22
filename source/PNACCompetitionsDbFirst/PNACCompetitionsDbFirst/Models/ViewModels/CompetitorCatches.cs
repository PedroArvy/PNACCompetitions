using PNACCompetitionsDbFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Models.ViewModels
{
  public class CompetitorCatches
  {

    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public string Name { get; set; }

    public IQueryable<Catch> Catches { get; set; }

    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************


    public string HeaviestFish(Catch item)
    {
      return Format.FormatNumber(item.HeaviestFish, 2);
    }


    public string Length(Catch item)
    {
      return Format.FormatNumber(item.LengthForPoints, 0);
    }


    #endregion

    #region *********************** Interfaces ***********************
    #endregion

  }
}