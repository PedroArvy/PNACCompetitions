using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Entities.ViewModels
{
  public class CompetitorListItem
  {
    public int CompetitorId { get; set; }
    public string Name { get; set; }
    public bool CanEdit { get; set; }
  }
}