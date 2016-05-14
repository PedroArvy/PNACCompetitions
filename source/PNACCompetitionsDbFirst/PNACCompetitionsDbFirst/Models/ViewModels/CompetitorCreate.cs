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
  public class CompetitorCreate
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public int CompetitorId { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Confirm password")]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    [Required]
    public string ConfirmPassword { get; set; }


    [MaxLength(100)]
    [DataType(DataType.EmailAddress)]
    [Display(Name = "Confirm your email")]
    [Required]
    public string Email { get; set; }


    //public bool HasMobile { get; set; }


    //[MaxLength(30)]
    //[DataType(DataType.PhoneNumber)]
    //public string Mobile { get; set; }


    public string Name { get; set; }


    [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    [Required]
    public string Password { get; set; }


    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************

    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}