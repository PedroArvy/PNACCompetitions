using PNACCompetitionsDbFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace PNACCompetitionsDbFirst.Entities
{
  public partial class Competition
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

    public bool CanAddEntries(Competitor competitor)
    {
      bool canAdd = false;

      if (competitor.Admin)
        canAdd = true;
      else if (Entries.Any(e => (e.IsReferee || e.IsTripCaptain) && e.CompetitorId == competitor.CompetitorId))
        canAdd = true;

      return canAdd;
    }


    public List<Catch> Catches()
    {
      List<Catch> catches = new List<Catch>();

      foreach (Entry entry in Entries)
      {
        catches.AddRange(entry.Catches);
      }

      return catches;
    }


    public List<Competitor> Competitors()
    {
      List<Competitor> competitors = new List<Competitor>();

      foreach (Entry entry in Entries.Where(e => e.Competitor.CompetitorType != (int)PNACCompetitionsDbFirst.Entities.Competitor.COMPETITOR_TYPE.NON_MEMBER))
      {
        if (!competitors.Contains(entry.Competitor))
          competitors.Add(entry.Competitor);
      }

      return competitors;
    }


    /// <summary>
    /// The End of the Competition whether it is single or multi day
    /// </summary>
    /// <returns></returns>
    public DateTime EndDateTime()
    {
      DateTime end = DateTime.Now;

      if (End != null)
      {
        end = (DateTime)End;
      }
      else
      {
        end = Start.AddDays(1);
        end = new DateTime(end.Year, end.Month, end.Day);
      }

      return end;
    }


    /// <summary>
    /// True if the competition is finished
    /// </summary>
    /// <returns></returns>
    public bool Finished()
    {
      return (DateTime.Now - EndDateTime()).TotalSeconds > 0;
    }


    public List<ExtremeFish> HeaviestFish()
    {
      List<ExtremeFish> heaviestList = new List<ExtremeFish>();
      ExtremeFish heaviest, next;
      double weight;

      foreach (Catch @catch in Catches())
      {
        if (heaviestList.Any(h => h.Fish.FishId == @catch.FishId))
          heaviest = heaviestList.Where(h => h.Fish.FishId == @catch.FishId).First();
        else
          heaviest = null;

        weight = @catch.HeaviestFish();

        if (weight != 0)
        {
          next = new ExtremeFish();
          next.Competitor = @catch.Entry.Competitor;
          next.Fish = @catch.Fish;
          next.Value = weight;
          next.Units = "kg";

          if (heaviest == null)
            heaviestList.Add(next);
          else if (heaviest.Value < weight)
          {
            heaviestList.RemoveAll(l => l.Fish.FishId == @catch.FishId);
            heaviestList.Add(next);
          }
          else if (heaviest.Value == weight)
          {
            heaviestList.Add(next);
          }
        }
      }

      return heaviestList;
    }


    public List<CompetitionPoint> LengthPoints(IQueryable<Catch> allPreviousCatches)
    {
      List<CompetitionPoint> points = new List<Entities.CompetitionPoint>();
      CompetitionPoint point;
      int smaller, bigger;

      foreach (Catch @catch in Catches().Where(c => c.Entry.Competitor.IsMember()))
      {
        if(@catch.LengthForPoints() > 0)
        {
          point = points.SingleOrDefault(p => p.Competitor.CompetitorId == @catch.Entry.CompetitorId);

          if (point == null)
          {
            point = new CompetitionPoint();
            point.Competitor = @catch.Entry.Competitor;
            point.Value = LengthPoints(@catch.LengthForPoints(), @catch.Fish, out smaller, out bigger, allPreviousCatches);
            points.Add(point);
          }
          else
            point.Value += LengthPoints(@catch.LengthForPoints(), @catch.Fish, out smaller, out bigger, allPreviousCatches);
        }
      }

      points = points.OrderBy(p => p.CompetitionPoints).Take(5).ToList();

      Rank(points);

      return points;
    }


    public int LengthPoints(int length, Fish fish, out int smaller, out int bigger, IQueryable<Catch> allPreviousCatches)
    {
      int points = 0;
      DateTime end = EndDateTime();

      smaller = allPreviousCatches.Where(c => c.Date <= end && c.FishId == fish.FishId && length >= c.Length).Count();
      bigger = allPreviousCatches.Where(c => c.Date <= end && c.FishId == fish.FishId && length < c.Length).Count();

      if (smaller + bigger == 0 || smaller == 0)
        points = 50;
      else
        points = 100 * smaller / (smaller + bigger);

      return points;
    }


    public List<ExtremeFish> LongestFish()
    {
      List<ExtremeFish> longestList = new List<ExtremeFish>();
      ExtremeFish longest, next;
      int length;

      foreach (Catch @catch in Catches())
      {
        if (longestList.Any(h => h.Fish.FishId == @catch.FishId))
          longest = longestList.Where(h => h.Fish.FishId == @catch.FishId).First();
        else
          longest = null;

        length = @catch.LengthForPoints();

        if(length != 0)
        {
          next = new ExtremeFish();
          next.Competitor = @catch.Entry.Competitor;
          next.Fish = @catch.Fish;
          next.Value = length;
          next.Units = "cm";

          if(longest == null)
            longestList.Add(next);
          else if (longest.Value < @catch.Length)
          {
            longestList.RemoveAll(l => l.Fish.FishId == @catch.FishId);
            longestList.Add(next);
          }
          else if (longest.Value == @catch.Length)
          {
            longestList.Add(next);
          }
        }
      }

      return longestList;
    }


    public DateTime NextCatchDate()
    {
      DateTime theDate = DateTime.Now;

      if (Finished())
      {
        if (Catches().Count > 0)
        {
          theDate = Catches().OrderByDescending(c => c.Date).First().Date;
        }
        else
        {
          theDate = Start;
        }
      }
      else
      {
        if (Catches().Count > 0)
        {
          theDate = Catches().OrderByDescending(c => c.Date).First().Date;
        }
      }

      return theDate;
    }


    private void Rank(List<CompetitionPoint> points)
    {
      int rank = 1;
      int value = 40;

      foreach (CompetitionPoint point in points.OrderByDescending(p => p.Value))
      {
        point.Order = rank;
        point.CompetitionPoints = value;

        if (value == 40)
          value = 35;
        else if (value == 35)
          value = 32;
        else if (value == 32)
          value = 30;
        else
          value--;

        rank++;
      }
    }


    public string WeighInDescription()
    {
      string description = "";

      if (WeighInTime != null)
      {
        description = Format.DateAndTime((DateTime)WeighInTime);
      }

      return description;
    }


    public List<CompetitionPoint> WeightPoints()
    {
      List<CompetitionPoint> points = new List<Entities.CompetitionPoint>();
      CompetitionPoint point;

      foreach (Catch @catch in Catches().Where(c => c.CatchAndRelease == false && c.Entry.Competitor.IsMember()))
      {
        point = points.SingleOrDefault(p => p.Competitor.CompetitorId == @catch.Entry.CompetitorId);

        if (point == null)
        {
          point = new CompetitionPoint();
          point.Competitor = @catch.Entry.Competitor;
          point.Value = @catch.CleanedWeight();
          point.Unit = "kg";
          points.Add(point);
        }
        else
          point.Value += @catch.Weight;
      }

      Rank(points);

      return points;
    }


    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }


  public class LeaderBoardItem
  {
    public Competitor Competitor { get; set; }
    public int Rank { get; set; }
    public double Points { get; set; }
  }


  public class CompetitionPoint
  {
    public Competitor Competitor { get; set; }
    public int CompetitionPoints { get; set; }
    public int Order { get; set; }
    public string Unit { get; set; }
    public double Value { get; set; }
  }


  public class ExtremeFish
  {
    public Competitor Competitor { get; set; }
    public Fish Fish { get; set; }
    public double Value { get; set; }
    public string Units { get; set; }
  }

}