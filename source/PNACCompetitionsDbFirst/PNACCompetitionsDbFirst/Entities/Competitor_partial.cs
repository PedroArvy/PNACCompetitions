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

    public string FriendlyName()
    {
      string name = FirstName;

      if(!string.IsNullOrWhiteSpace(NickName))
      {
        name += " \"" + NickName + "\"";
      }

      name += " " + LastName;

      return name;
    }

    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}