using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Models.ViewModels.Entries
{
  public class CompetitionEntries
  {
    public int CompetitionId { get; set; }
    public int TripCaptain { get; set; }

    public List<CompetitorEntry> Competitors { get; set; }
  }
}
