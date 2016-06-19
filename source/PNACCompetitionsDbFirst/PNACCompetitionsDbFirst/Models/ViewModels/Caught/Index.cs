using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Models.ViewModels.Caught
{
  public class Index
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************


    public List<FishCaught> Caught = new List<FishCaught>();

    public string Species { get; set; }

    public string Title { get; set; }

    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************

    public int AverageLength()
    {
      IEnumerable<FishCaught> caught = Caught.Where(c => c.Length != 0);
      return (int)Math.Round((double)caught.Sum(c => c.Length) / caught.Count(), 0);
    }


    public double AverageWeight()
    {
      IEnumerable<FishCaught> caught = Caught.Where(c => c.Weight != 0);
      return Math.Round(caught.Sum(c => c.Weight) / caught.Count(), 2);
    }


    public string MaximumLength()
    {
      FishCaught maximum = Caught.OrderByDescending(c => c.Length).First();
      return  "Maximum Length: " + maximum.Length + "cm, " + maximum.CompetitorName + ", " + maximum.Competition + ", " + maximum.Date.ToString(Format.DATE_FORMAT_CS);
    }


    public string MaximumWeight()
    {
      FishCaught maximum = Caught.OrderByDescending(c => c.Weight).First();
      return "Maximum Weight: " + maximum.Weight + "kg, " + maximum.CompetitorName + ", " + maximum.Competition + ", " + maximum.Date.ToString(Format.DATE_FORMAT_CS);
    }

    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}