using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Models.ViewModels.Results
{
  public class WeightResult
  {
    public int CompetitorId { get; set; }

    public string Name { get; set; }

    public double Weight { get; set; }

    public double Points { get; set; }
  }


}