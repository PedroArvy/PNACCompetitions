﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Competitions.POCO
{

  public class Competitor
  {
    #region *********************** Constants ************************

    public enum GENDER { UNKNOWN, MALE, FEMALE }

    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    //many to many
    public List<CompetitorCompetition> CompetitorCompetitions { get; set; }

    public List<Result> Results { get; set; }

    public GENDER Gender { get; set; }

    public int Id { get; set; }

    [Column(TypeName = "varchar(100)"), Required]
    public string FirstName { get; set; }

    [Column(TypeName = "varchar(100)"), Required]
    public string LastName { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string NickName { get; set; }

    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion


  }
}
