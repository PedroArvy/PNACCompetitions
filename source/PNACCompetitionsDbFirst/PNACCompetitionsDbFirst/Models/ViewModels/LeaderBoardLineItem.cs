using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Models.ViewModels
{
  public class LeaderBoardLineItem
  {
    public int Order { get; set; }
    public string Name { get; set; }
    public int FormulaPoints { get; set; }
    public int TrialPoints { get; set; }
  }
}