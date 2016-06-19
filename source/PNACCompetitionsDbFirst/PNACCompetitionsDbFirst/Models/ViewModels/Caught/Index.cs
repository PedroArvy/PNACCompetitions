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

    public string Species;

    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************

    public int AverageLength()
    {
      IEnumerable<FishCaught> caught = Caught.Where(c => c.Length != 0);
      return (int)Math.Round((double)caught.Sum(c => c.Length) / caught.Count());
    }


    public double AverageWeight()
    {
      IEnumerable<FishCaught> caught = Caught.Where(c => c.Weight != 0);
      return caught.Sum(c => c.Length) / caught.Count();
    }


    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}