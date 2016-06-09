using PNACCompetitionsDbFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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


    public List<LengthResult> LengthResults()
    {
      LengthResult result;
      List<LengthResult> results = new List<LengthResult>();

      foreach (Catch @catch in Catches().Where(c => c.Length != 0))
      {
        result = new LengthResult() { Competition = this, Fish = @catch.Fish, CompetitorId = @catch.Entry.CompetitorId, Name = @catch.Entry.Competitor.FriendlyName(), Length = @catch.Length };
        results.Add(result);
      }

      return results;
    }


    public DateTime NextCatchDate()
    {
      DateTime theDate = DateTime.Now;

      if(Finished())
      {
        if(Catches().Count > 0)
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


    public string WeighInDescription()
    {
      string description = "";

      if (WeighInTime != null)
      {
        description = Format.DateAndTime((DateTime)WeighInTime);
      }

      return description;
    }


    public List<WeightResult> WeightResults()
    {
      WeightResult result;
      List<WeightResult> results = new List<WeightResult>();
      int count = 0;
      int points = 0;

      foreach (Competitor competitor in Competitors())
      {
        result = new WeightResult() { CompetitorId = competitor.CompetitorId, Name = competitor.FriendlyName(), Weight = competitor.Weight(this) };
        results.Add(result);
      }

      foreach (WeightResult result1 in results.OrderByDescending(r => r.Weight))
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

        result1.Points = points;
        count++;
      }

      return results;
    }


    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }


  public class LengthResult
  {
    public Competition Competition { get; set; }

    public int CompetitorId { get; set; }

    public Fish Fish { get; set; }

    public string Name { get; set; }

    public double Length { get; set; }

    public double Points { get; set; }
  }


  public class WeightResult
  {
    public int CompetitorId { get; set; }

    public string Name { get; set; }

    public double Weight { get; set; }

    public double Points { get; set; }
  }


}