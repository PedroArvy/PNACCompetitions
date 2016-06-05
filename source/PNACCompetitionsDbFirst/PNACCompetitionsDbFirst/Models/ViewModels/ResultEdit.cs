using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Models.ViewModels
{
  public class ResultEdit
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    [Display(Name = "Competitor")]
    public int EntrantId { get; set; }

    public List<Entrant> Entrants { get; set; }

    public int Length { get; set; }

    public bool LengthOnly {get; set;}

    public int Number { get; set; }

    public List<Species> Species { get; set; }

    public double Weight { get; set; }


    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }


  public class Entrant
  {
    public int CompetitorId { get; set; }
    public string Name { get; set; }
  }


  public class Species
  {
    public int FishId { get; set; }
    public string Name { get; set; }
  }


}