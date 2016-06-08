using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PNACCompetitionsDbFirst.Models.ViewModels
{
  public class CatchEdit
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public int CatchId { get; set; }

    public bool Cleaned { get; set; }

    public int CompetitionId { get; set; }

    [Display(Name = "Competitor")]
    [Required(ErrorMessage = "You need to select a competitor")]
    public int EntrantId { get; set; }

    public List<SelectListItem> Entrants { get; set; }

    [Display(Name = "Length (cm)")]
    public int Length { get; set; }
    public List<SelectListItem> Lengths { get; set; }

    [Display(Name = "Catch and release?")]
    [Required(ErrorMessage = "You need to select a value for Catch and Release")]
    public string CatchAndRelease {get; set;}


    public bool GoToNew { get; set; }


    [Display(Name = "Quantity")]
    public int ? Quantity { get; set; }
    public List<SelectListItem> Numbers { get; set; }

    [Display(Name = "Fish")]
    [Required(ErrorMessage = "You need to select a fish")]
    public int FishId { get; set; }
    public IEnumerable<SelectListItem> Fish { get; set; }

    [Display(Name = "Weight (kg)")]
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