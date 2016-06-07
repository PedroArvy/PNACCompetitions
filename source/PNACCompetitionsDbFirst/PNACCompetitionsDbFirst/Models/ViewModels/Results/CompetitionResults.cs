using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Models.ViewModels.Results
{
  public class CompetitionResults
  {

    public int CompetitonId { get; set; }

    public List<CompetitorResult> Results { get; set; } = new List<CompetitorResult>();

  }
}


