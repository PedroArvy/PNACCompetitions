using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PNACCompetitionsDbFirst.Models.ViewModels
{
  public class ResultEdit
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public int CompetitionId { get; set; }

    [Display(Name = "Competitor")]
    [Required(ErrorMessage = "You need to select an entrant")]
    public int EntrantId { get; set; }

    public List<SelectListItem> Entrants { get; set; }

    [Display(Name = "Length (cm)")]
    [Required(ErrorMessage = "You need to select a length")]
    public int Length { get; set; }
    public List<SelectListItem> Lengths { get; set; }

    [Display(Name = "Catch and release?")]
    [Required(ErrorMessage = "You need to select a value for Catch and Release")]
    public string CatchAndRelease {get; set;}

    [Display(Name = "Quantity")]
    [Required(ErrorMessage = "You need to select a quantity")]
    [Range(1, 100, ErrorMessage = "You need to select a quantity")]
    public int Quantity { get; set; }
    public List<SelectListItem> Numbers { get; set; }

    [Display(Name = "Fish")]
    [Required(ErrorMessage = "You need to select a fish")]
    public int FishId { get; set; }
    public List<SelectListItem> Fish { get; set; }

    [Display(Name = "Weight (kg)")]
    [Range(0.1, 200, ErrorMessage = "You need to select a weight")]
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