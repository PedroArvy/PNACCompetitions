using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Competitions.Entities
{
    public class CompetitorCompetition
    {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************



    public int CompetitorId { get; set; }
    public Competitor Competitor { get; set; }


    public int CompetitionId { get; set; }
    public Competition Competition { get; set; }



    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}
