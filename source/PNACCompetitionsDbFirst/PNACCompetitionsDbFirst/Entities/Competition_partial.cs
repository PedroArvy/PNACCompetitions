using PNACCompetitionsDbFirst.Models;
using PNACCompetitionsDbFirst.Models.ViewModels.Results;
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


    private void AddCompetitionPoints(IEnumerable<Result> results)
    {
      int count = 0;
      int points = 0;

      foreach (Result result in results)
      {
        if (count == 0)
          points = 40;
        else if (count == 1)
          points = 35;
        else if (count == 2)
          points = 32;
        else if (count == 3)
          points = 30;
        else
          points--;

        result.Points = points;
        count++;
      }
    }


    /// <summary>
    /// Complete the Points for the List<LengthResult>
    /// </summary>
    /// <param name="results"></param>
    /*
    private void AddLengthPoints(List<LengthResult> results, List<Catch> catches)
    {
      int smaller, bigger;
      DateTime end = EndDateTime();

      if (results.Count > 0)
      {
        foreach (LengthResult result in results)
        {
          result.LengthPoints = CatchPoints(result.Length, result.Fish, catches, out smaller, out bigger);
        }
      }
    }
    */


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



    public List<CompetitionPoint> LengthPoints()
    {
      List<CompetitionPoint> points = new List<Entities.CompetitionPoint>();
      CompetitionPoint point;
      int smaller, bigger;

      foreach (Catch @catch in Catches())
      {
        point = points.SingleOrDefault(p => p.Competitor.CompetitorId == @catch.Entry.CompetitorId);

        if (point == null)
        {
          point = new CompetitionPoint();
          point.Competitor = @catch.Entry.Competitor;
          point.Value = LengthPoints(@catch.LengthForPoints(), @catch.Fish, out smaller, out bigger);
          points.Add(point);
        }
        else
          point.Value += LengthPoints(@catch.LengthForPoints(), @catch.Fish, out smaller, out bigger);
      }

      Rank(points);

      return points;
    }


    public int LengthPoints(int length, Fish fish, out int smaller, out int bigger)
    {
      int points = 0;
      DateTime end = EndDateTime();
      List<Catch> catches = Catches();

      smaller = catches.Where(c => c.Date <= end && c.FishId == fish.FishId && length >= c.Length).Count();
      bigger = catches.Where(c => c.Date <= end && c.FishId == fish.FishId && length < c.Length).Count();

      if (smaller + bigger == 0 || smaller == 0)
        points = 50;
      else
        points = 100 * smaller / (smaller + bigger);

      return points;
    }


    public IEnumerable<Result> LengthResults()
    {
      Result result;
      List<Result> results = new List<Result>();
      /*
      List<Catch> catches = Catches();

      foreach (Catch @catch in catches.Where(c => c.CatchAndRelease && c.Length != 0))
      {
        result = new LengthResult() { Competition = this, Fish = @catch.Fish, CompetitorName = @catch.Entry.Competitor.FriendlyName(), Length = @catch.Length };
        results.Add(result);
      }

      foreach (Catch @catch in catches.Where(c => !c.CatchAndRelease))
      {
        result = new LengthResult() { Competition = this, Fish = @catch.Fish, CompetitorName = @catch.Entry.Competitor.FriendlyName() };

        if (@catch.Number == 1)
          result.Length = @catch.Length;
        else if (@catch.Number >= 1)
          result.Length = @catch.Longest;

        results.Add(result);
      }

      AddLengthPoints(results, catches);
      AddCompetitionPoints(results.OrderByDescending(r => r.Length));
      Rank(results);
      */

      return results;
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

      foreach (CompetitionPoint point in points.OrderBy(p => p.Value))
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
      }
    }


    public List<Result> Results()
    {
      Result result;
      List<Result> results = new List<Result>();

      /*
      foreach (Competitor competitor in Competitors())
      {
        result = new Result() { CompetitorId = competitor.CompetitorId, CompetitorName = competitor.FriendlyName(), Weight = competitor.Weight(this) };
        results.Add(result);
      }
      */

      //AddCompetitionPoints(results.OrderByDescending(r => r.Weight));
      Rank(results);

      return results;
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


    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }


  public class CompetitionPoint
  {
    public Competitor Competitor { get; set; }
    public int CompetitionPoints { get; set; }
    public int Order { get; set; }
    public int Value { get; set; }
  }

}