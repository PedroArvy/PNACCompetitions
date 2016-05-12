using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using static PNACCompetitionsDbFirst.Entities.Competitor;

namespace PNACCompetitionsDbFirst.Entities.ViewModels
{
  public class CompetitorEdit
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public bool Admin { get; set; }

    public bool Hidden { get; set; }

    public int CompetitorId { get; set; }

    [Required]
    [DisplayName("Competitor type")]
    public int CompetitorType { get; set; }


    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    public string Email { get; set; }


    [Required]
    [DisplayName("First name")]
    public string FirstName { get; set; }

    [Required]
    public int Gender { get; set; }

    [Required]
    [DisplayName("Last name")]
    public string LastName { get; set; }

    [DisplayName("Nick name")]
    public string NickName { get; set; }

    [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Confirm password")]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; }


    public string FriendlyName { get; set; }


    public bool ShowAdmin { get; set; }

    public bool ShowHidden { get; set; }

    public bool ShowCompetitorType { get; set; }

    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}