using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Entities
{
  public partial class Competitor
  {
    #region *********************** Constants ************************

    public enum COMPETITOR_TYPE
    {
      [Display(Name = "Select")]
      UNASSIGNED,

      [Display(Name = "Non member")]
      NON_MEMBER,

      [Display(Name = "Junior")]
      JUNIOR,

      [Display(Name = "Senior")]
      SENIOR
    };

    public enum GENDER
    {

      [Display(Name = "Select")]
      UNASSIGNED,

      [Display(Name = "Male")]
      MALE,

      [Display(Name = "Female")]
      FEMALE

    };

    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************


    public Competitor DuplicateSpouse()
    {
      Competitor competitor = new Competitor();

      if (FirstName.IndexOf("&") != -1)
      {
        competitor.FirstName = FirstName.Substring(FirstName.IndexOf("&") + 1).Trim();
        competitor.LastName = LastName.Trim();
        competitor.NickName = "";
        competitor.CompetitorType = CompetitorType;
        competitor.Gender = 2;//guess female
        competitor.ClubId = ClubId;
        competitor.Suburb = Suburb.Trim();
        competitor.Phone = Phone.Trim();
        competitor.Mobile = "";
        competitor.Email = "";
      }
      else
        throw new Exception("DuplicateSpouse");

      return competitor;
    }


    public string FriendlyName()
    {
      string name = FirstName.Trim();

      if(!string.IsNullOrWhiteSpace(NickName))
      {
        name += " \"" + NickName.Trim() + "\"";
      }

      name += " " + LastName.Trim();

      return name;
    }

    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}