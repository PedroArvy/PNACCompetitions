using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Models.ViewModels.Entries
{
  public class CompetitorEntry
  {
    public string Name { get; set; }

    public int CompetitorId { get; set; }

    public bool IsReferee { get; set; }

    public bool IsTripCaptain { get; set; }
  }
}


