using PNACCompetitions.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;


namespace PNACCompetitions
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



    [NotMapped]
    public Club Club
    {
      get
      {
        return Season.Club;
      }
    }

    public List<Entry> Entries { get; set; }


   public ENVIRONMENT Environment { get; set; }

    public int CompetitionId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? End { get; set; }

    [MaxLength(100)]
    [Column(TypeName = "varchar")]
    public string Name { get; set; }

    [Required]
    [Column(TypeName = "datetime")]
    public DateTime Start { get; set; }

    /*
    public int? Referee1Id { get; set; }
    public virtual Competitor Referee1 { get; set; }

    public int? Referee2Id { get; set; }
    public virtual Competitor Referee2 { get; set; }

    public int? Referee3Id { get; set; }
    public virtual Competitor Referee3 { get; set; }


    public int? TripCaptainId { get; set; }
    public virtual Competitor TripCaptain { get; set; }
    */

    public int SeasonId { get; set; }
    public Season Season { get; set; }

    [MaxLength(100)]
    [Column(TypeName = "varchar"), Required]
    public string Venue { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime WeighInTime { get; set; }

    #endregion


    #region *********************** Initialisation *******************

    public Competition()
    {
    }

    public Competition(Club club, string venue, string name, DateTime start, DateTime? end, ENVIRONMENT environment, Season season)
    {
      //Venue = venue;
      Name = name;
      //Start = start;
      //End = end;
      //Environment = environment;
      SeasonId = season.SeasonId;

      if (season != null)
      {
        Season = season;
        SeasonId = season.SeasonId;

        // ClubId = season.ClubId;
        //Club = season.Club;
      }
      else
        throw new Exception("Competition(string name, DateTime start, DateTime ? end, ENVIRONMENT environment, Season season)");
    }

    #endregion


    #region *********************** Methods **************************


    private List<CompetitorPoints> CompetitorPoints()
    {
      List<CompetitorPoints> weights = new List<CompetitorPoints>();

      /*
      Competitor competitor;
      CompetitorPoints weight;

      foreach (Catch @catch in Catches.Where(c => c.Weight > 0 && c.Length > c.Fish.Minimum))
      {
        competitor = @catch.Competitor;

        weight = weights.SingleOrDefault(w => w.Competitor.CompetitorId == competitor.CompetitorId);

        if (weight != null)
          weight.Weight += @catch.CompetitionWeight();
        else
          weights.Add(new CompetitorPoints() { Competitor = @catch.Competitor, Weight = @catch.CompetitionWeight() });
      }

  */
      return weights;
    }


    public List<CompetitorPoints> Points()
    {
      List<CompetitorPoints> points = new List<CompetitorPoints>();
      int POINT = 40;

      foreach (CompetitorPoints point in points.OrderByDescending(w => w.Weight))
      {
        point.Points = POINT;

        if (POINT == 40)
          POINT -= 5;
        else if (POINT == 35)
          POINT -= 3;
        else if (POINT == 32)
          POINT -= 2;
        else
          POINT--;
      }

      return points;
    }


    #endregion


    #region *********************** Interfaces ***********************
    #endregion


  }

  public class CompetitorPoints
  {
    //public Competitor Competitor { get; set; }
    public int Points { get; set; }
    public double Weight { get; set; }
  }


}
