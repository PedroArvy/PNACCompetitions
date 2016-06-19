using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Entities
{
  public partial class Fish
  {
    #region *********************** Constants ************************

    public enum ENVIRONMENT { FRESHWATER = 1, ESTUARY = 2, SALTWATER = 3 }

    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************
    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************


    public bool HasEnvironment(Environment environment)
    {
      return Environments.Any(e => e.EnvironmentId == environment.EnvironmentId);
    }


    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}