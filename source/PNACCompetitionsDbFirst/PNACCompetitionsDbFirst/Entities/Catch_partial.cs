using PNACCompetitionsDbFirst.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Entities
{
  public partial class Catch
  {

    #region *********************** Constants ************************

    private const double BASE_POINTS = 100;
    private const double FACTOR = 1.15;
    private const double MAXIMUM_POINTS = 1000;
    public const double MAX_POWER = 16.5133;

    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************
    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************

    public double FormulaPoints()
    {
      double value = 0;

      if (Length > Fish.Minimum)
      {
        double @base = Fish.Difficulty * BASE_POINTS;
        double percentageToMax = (double)(Length - Fish.Minimum) / (double)(Fish.Maximum - Fish.Minimum);
        double two_power_size = PowerN(percentageToMax * 10);

        value = @base + (MAXIMUM_POINTS - @base) * percentageToMax * two_power_size / MAX_POWER;

        value = Math.Round(value, 2, MidpointRounding.AwayFromZero);
      }

      return value;
    }


    public LeaderBoardLineItem LeaderBoardLineItem()
    {
      LeaderBoardLineItem item = new LeaderBoardLineItem();

      item.Name = Entry.Competitor.FriendlyName();
      item.FormulaPoints = (int)Math.Round(FormulaPoints());
      item.TrialPoints = TrialPoints();

      return item;
    }


    public int LengthForPoints()
    {
      int length = Length;

      if (!CatchAndRelease && Number > 1)
        length = Longest;

      return length;
    }


    public static double PowerN(double n)
    {
      return Math.Pow(2, Math.Pow(FACTOR, n));
    }


    public int TrialPoints()
    {
      int value = 0;

      if (Length > Fish.Minimum)
        value = 5 + Length - Fish.Minimum;

      return value;
    }


    #endregion


    #region *********************** Interfaces ***********************
    #endregion





  }
}