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

    public int CompetitorId { get; set; }

    [DisplayName("Competitor type")]
    public COMPETITOR_TYPE CompetitorType { get; set; }

    [DisplayName("First name")]
    public string FirstName { get; set; }

    public GENDER Gender { get; set; }

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

    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}