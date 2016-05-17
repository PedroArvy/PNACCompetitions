using PNACCompetitionsDbFirst.Models.ViewModels.Entries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using static PNACCompetitionsDbFirst.Entities.Competitor;

namespace PNACCompetitionsDbFirst.Models.ViewModels
{
  public class CompetitionEdit
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************


    public List<CompetitorEntry> CompetitionEntries { get; set; }


    public int CompetitionId { get; set; }


    public string DayType { get; set; }


    [Display(Name = "End date")]
    [Required]
    public string EndDate { get; set; }


    [Display(Name = "End time")]
    [Required]
    public string EndTime { get; set; }


    public string MemberNames { get; set; }


    [Display(Name = "Start date")]
    [Required]
    public string StartDate { get; set; }


    [Display(Name = "Start time")]
    [Required]
    public string StartTime { get; set; }

    public int TripCaptainId { get; set; }

    [Required]
    [MaxLength(100)]
    public string Venue { get; set; }


    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************


    public string CompetitionEntriesJson()
    {
      string json = "";

      foreach(CompetitorEntry entry in CompetitionEntries)
      {
        if (json.Length > 0)
          json += ",\n";
        json += "new CompetitorData('" + entry.Name.Replace("'", "\'") + "', " + entry.CompetitorId + ", " + entry.IsTripCaptain.ToString().ToLower() + ", " + entry.IsReferee.ToString().ToLower() + ")";
      }

      return json;
    }


    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}