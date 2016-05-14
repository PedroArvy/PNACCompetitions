using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using static PNACCompetitionsDbFirst.Entities.Competitor;

namespace PNACCompetitionsDbFirst.Models.ViewModels
{
  public class CompetitionEdit
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************


    public int CompetitionId { get; set; }


    [Display(Name = "Start date")]
    [Required]
    public string StartDate { get; set; }


    [Display(Name = "Start time")]
    [Required]
    public string StartTime { get; set; }


    [Required]
    [MaxLength(100)]
    public string Venue { get; set; }


    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}