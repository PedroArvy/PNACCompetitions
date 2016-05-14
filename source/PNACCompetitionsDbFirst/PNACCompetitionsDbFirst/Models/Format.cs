using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Models
{
  public class Format
  {
    #region *********************** Constants ************************
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

      return theDate.ToString("dddd d MMM yyyy");
    }


    public static string TimeOnly(DateTime theDate)
    {
      if (theDate == null)
        theDate = new DateTime();

      return theDate.ToString("h:mm tt");
    }

    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}