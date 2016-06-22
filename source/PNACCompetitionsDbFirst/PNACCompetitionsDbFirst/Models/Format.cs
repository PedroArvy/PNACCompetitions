using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Models
{
  public class Format
  {
    #region *********************** Constants ************************

    public const string DATE_FORMAT_CS = "dddd, d MMMM yyyy";
    public const string DATE_FORMAT_JS = "dddd, d mmmm yyyy";


    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************
    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************

    public static string DateAndTime(DateTime theDate)
    {
      string description = "";

      if (theDate != null && theDate.Year != 1)
      {
        string format = "ddd d MMMM";

        if (((DateTime)theDate).Year != DateTime.Now.Year)
          format += " yyyy";

        if (theDate.Hour != 0)
        {
          format += ", h";

          if (((DateTime)theDate).Minute != 0)
            format += ":mm";
        }

        description = ((DateTime)theDate).ToString(format);

        if (theDate.Hour != 0)
        {
          if (((DateTime)theDate).Hour >= 12)
            description += "pm";
          else
            description += "am";
        }
      }

      return description;
    }


    public static string DateOnly(DateTime theDate)
    {
      if (theDate == null)
        theDate = new DateTime();

      return theDate.ToString(DATE_FORMAT_CS);
    }


    public static string FormatNumber(double number, int decimals)
    {
      string value = "";

      if (number == 0)
        value = "NA";
      else
        value = Math.Round(number, decimals).ToString();

      return value;
    }


    public static string TimeOnly(DateTime theDate)
    {
      if (theDate == null)
        theDate = new DateTime();

      return theDate.ToString("h:mm tt");
    }


    public static string TitleCase(string str)
    {
      TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
      return myTI.ToTitleCase(str);
    }

    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}