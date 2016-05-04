﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Competitions.Entities
{

  public class Competitor
  {
    #region *********************** Constants ************************

    public enum COMPETITOR_TYPE { UNASSIGNED, NON_MEMBER, SENIOR, JUNIOR }

    public enum GENDER { UNKNOWN, MALE, FEMALE }

    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public int ClubId { get; set; }
    public Club  Club { get; set; }

    //many to many
    public List<CompetitorCompetition> CompetitorCompetitions { get; set; }

    public COMPETITOR_TYPE CompetitorType { get; set; }

    public List<Catch> Results { get; set; }

    public GENDER Gender { get; set; }

    public int Id { get; set; }

    [Column(TypeName = "varchar(100)"), Required]
    public string FirstName { get; set; }

    [Column(TypeName = "varchar(100)"), Required]
    public string LastName { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string NickName { get; set; }

    //public List<Competition> RefereedCompetitions { get; set; }

    //public List<Competition> TripCaptaincies { get; set; }

    #endregion


    #region *********************** Initialisation *******************

    public Competitor()
    {
    }


    public Competitor(string firstname, string lastname, string nickname, Club club, COMPETITOR_TYPE competitorType, GENDER gender)
    {
      if(club != null)
      {
        Club = club;
        ClubId = club.Id;
      }

      CompetitorType = competitorType;
      Gender = gender;
      FirstName = firstname;
      LastName = lastname;
      NickName = nickname;
    }

    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion


  }
}