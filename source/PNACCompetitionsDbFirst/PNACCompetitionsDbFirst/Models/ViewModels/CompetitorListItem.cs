using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Models.ViewModels
{
  public class CompetitorListItem
  {
    public bool CanCreatePassword { get; set; }
    public int CompetitorId { get; set; }
    public bool CanEdit { get; set; }
    public bool Hide { get; set; }
    public bool IsAdmin { get; set; }
    public bool IsLoggedIn { get; set; }
    public bool IsRegistered { get; set; }
    public string Name { get; set; }
  }
}