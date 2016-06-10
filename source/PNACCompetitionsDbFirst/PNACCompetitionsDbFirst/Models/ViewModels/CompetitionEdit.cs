using PNACCompetitionsDbFirst.Models.ViewModels.Components;
using PNACCompetitionsDbFirst.Models.ViewModels.Entries;
using PNACCompetitionsDbFirst.Models.ViewModels.Catches;
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

    public enum TABS { DETAILS = 0, COMPETITORS = 1, RESULTS = 2};

    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public bool Begun { get; set; }

    public List<CompetitorEntry> CompetitionEntries { get; set; }

    public CompetitionCatches CompetitionCatches { get; set; }


    public int CompetitionId { get; set; }


    public string DayType { get; set; }


    [Display(Name = "End date")]
    [Required]
    public string EndDate { get; set; }


    [Display(Name = "End time")]
    [Required]
    public string EndTime { get; set; }


    [Required]
    public int EnvironmentId { get; set; }

    public List<RadioValue> Environments { get; set; }

 
    public string MemberNames { get; set; }


    [Display(Name = "Start date")]
    [Required]
    public string StartDate { get; set; }


    [Display(Name = "Start time")]
    [Required]
    public string StartTime { get; set; }


    public TABS TabId { get; set; }


    [Required]
    [MaxLength(100)]
    public string Venue { get; set; }


    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************


    public string ActiveTab()
    {
      string active = "-1";

      switch(TabId)
      {
        case TABS.COMPETITORS: active = ((int)TABS.COMPETITORS).ToString(); break;
        case TABS.DETAILS: active = ((int)TABS.DETAILS).ToString(); break;
        case TABS.RESULTS: active = ((int)TABS.RESULTS).ToString(); break;
      }

      return active;
    }


    public string CompetitionEntriesJson()
    {
      string json = "";

      foreach (CompetitorEntry entry in CompetitionEntries)
      {
        if (json.Length > 0)
          json += ",\n";

        json += "new Competitor(\"" + entry.CompetitorId + "\", " + entry.IsReferee.ToString().ToLower() + ")";
      }

      //add at least one blank line
      if (json.Length == 0)
        //json = "new CompetitorData('', 0, false, false)";
        // id, name, isRef
        json = "new Person(0, false)";

      return json;
    }


    public string EntryRow(CompetitorEntry entry)
    {
      string row = "";

      row += "<tr class=\"competitor-row\">";

      row += "\n<td>";

      if(!string.IsNullOrWhiteSpace(entry.Name))
        row += "\n<a href=\"#\" class=\"btn btn-primary btn-sm DeleteCompetitor white-button\">Delete</a>";
      else
        row += "\n<a href=\"#\" class=\"btn btn-primary btn-sm DeleteCompetitor white-button\" style=\"display:none\">Delete</a>";

      row += "\n</td>";

      row += "\n<td>";
      row += "\n<input data-val-competitorId=\"" + entry.CompetitorId + "\" class=\"competitorName\" type=\"text\" value=\"" + entry.Name + "\"/>";
      row += "\n</td>";

      row += "\n<td>";
      row += "\n<input type=\"radio\" name=\"TripCaptain\" class=\"TripCaptain\"/>";
      row += "\n</td>";

      row += "\n<td>";

      row += "\n<input type=\"checkbox\" name=\"Referee\" class=\"Referee\"/>";
      row += "\n</td>";

      row += "\n</tr>";

      return row;
    }


    public string EntryRowEmpty()
    {
      string row;
      CompetitorEntry entry = new CompetitorEntry();

      entry.Name = "";

      row = EntryRow(entry).Replace("\n", "");

      return "'" + row + "'";
    }

    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}