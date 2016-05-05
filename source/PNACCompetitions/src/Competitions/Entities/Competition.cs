using Competitions.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;


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


    public List<Catch> Catches { get; set; }

    public int ClubId { get; set; }
    public Club Club { get; set; }


    /*
    [NotMapped]
    public IEnumerable<Competitor> Competitors
    {
      get
      {
        List<Competitor> competitors = new List<Competitor>();

        if (Catches != null)
        {
          foreach (Catch @catch in Catches)
          {
            competitors.Add(@catch.Competitor);
          }
        }

        return competitors.Distinct();
      }
    }
    */


    public ENVIRONMENT Environment { get; set; }

    public int CompetitionId { get; set; }

    public DateTime? End { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string Name { get; set; }

    [Required]
    public DateTime Start { get; set; }

    /*
    public int? Referee1Id { get; set; }
    public Competitor Referee1 { get; set; }

    public int? Referee2Id { get; set; }
    public Competitor Referee2 { get; set; }

    public int? Referee3Id { get; set; }
    public Competitor Referee3 { get; set; }
    */

    public int SeasonId { get; set; }
    public Season Season { get; set; }

    /*
    public int? TripCaptainId { get; set; }
    public Competitor TripCaptain { get; set; }
    */

    [Column(TypeName = "varchar(100)"), Required]
    public string Venue { get; set; }

    public DateTime WeighInTime { get; set; }

    #endregion


    #region *********************** Initialisation *******************

    public Competition()
    {
    }

    public Competition(string venue, string name, DateTime start, DateTime? end, ENVIRONMENT environment, Season season)
    {
      Venue = venue;
      Name = name;
      Start = start;
      End = end;
      Environment = environment;
      SeasonId = season.SeasonId;

      if (season != null)
      {
        Season = season;
        SeasonId = season.SeasonId;

        //ClubId = season.ClubId;
        //Club = season.Club;
      }
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
