using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Models.ViewModels.Results
{
  public class CompetitorResult
  {
    public string CompetitorName { get; set; }

    public string FishName { get; set; }

    public int Length { get; set; }

    public bool LengthOnly { get; set; }

    public int Number { get; set; }

    public float Weight { get; set; }
  }
}


