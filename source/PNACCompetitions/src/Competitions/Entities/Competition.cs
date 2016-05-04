﻿using Competitions.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Competitions
{
  public enum ENVIRONMENT { NOT_DEFINED, FRESHWATER, SALTWATER, ESTUARY, ALL }

  // This project can output the Class library as a NuGet Package.
  // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
  public class Competition
  {
    #region *********************** Constants ************************


    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public ENVIRONMENT Environment { get; set; }

    public int Id { get; set; }

    public DateTime? End { get; set; }

    [Column(TypeName = "varchar(100)"), Required]
    public string Name { get; set; }

    [Required]
    public DateTime Start { get; set; }

    //many to many
    public List<CompetitorCompetition> CompetitorCompetitions { get; set; }

    //public int Referee1Id { get; set; }
    //public Competitor Referee1 { get; set; }

    //public int Referee2Id { get; set; }
    //public Competitor Referee2 { get; set; }

    public List<Catch> Results { get; set; }

    public int SeasonId { get; set; }
    public Season Season { get; set; }

    public int ? TripCaptainId { get; set; }
    public Competitor TripCaptain { get; set; }

    public DateTime WeighInTime { get; set; }

    #endregion


    #region *********************** Initialisation *******************

    public Competition()
    {

    }

    public Competition(string name, DateTime start, DateTime ? end, ENVIRONMENT environment, Season season)
    {
      Name = name;
      Start = start;
      End = end;
      Environment = environment;
      SeasonId = season.Id;

      if (season != null)
        Season = season;
      else
        throw new Exception("Competition(string name, DateTime start, DateTime ? end, ENVIRONMENT environment, Season season)");
    }

    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion





  }
}