using PNACCompetitionsDbFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Models.ViewModels.Results
{

  public class LengthResult
  {
    public Competition Competition { get; set; }

    public int CompetitorId { get; set; }

    public Fish Fish { get; set; }

    public string Name { get; set; }

    public double Length { get; set; }

    public double Points { get; set; }
  }


}