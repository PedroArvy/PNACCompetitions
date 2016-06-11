using PNACCompetitionsDbFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Models.ViewModels.Results
{
  public abstract class Result
  {
    public string Name { get; set; }

    public double Points { get; set; }

    public int Rank { get; set; }
  }
}