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
      UNASSIGNED = 0,

      [Display(Name = "Non member")]
      NON_MEMBER = 1,

      [Display(Name = "Junior")]
      JUNIOR = 2,

      [Display(Name = "Senior")]
      SENIOR = 3
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

      if (!string.IsNullOrWhiteSpace(NickName))
      {
        name += " \"" + NickName.Trim() + "\"";
      }

      name += " " + LastName.Trim();

      return name;
    }


    public bool IsMember()
    {
      return CompetitorType == (int)COMPETITOR_TYPE.SENIOR;
    }


    public string ShortName()
    {
      string name = FriendlyName();

      if (!string.IsNullOrWhiteSpace(NickName))
      {
        name = NickName;
      }

      return name;
    }


    public double Weight(Competition competition)
    {
      double points = 0;

      foreach (Entry entry in competition.Entries.Where(e => e.CompetitionId == competition.CompetitionId && e.CompetitorId == CompetitorId))
      {
        points += Weight(entry);
      }

      return points;
    }


    private double Weight(Entry entry)
    {
      double points = 0;

      foreach (Catch @catch in entry.Catches.Where(c => c.CatchAndRelease == false))
      {
        if (!@catch.Cleaned)
          points += 0.9 * @catch.Weight;
        else
          points += @catch.Weight;
      }

      return points;
    }

    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}