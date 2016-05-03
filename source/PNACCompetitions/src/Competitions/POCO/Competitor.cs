using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Competitions.POCO
{

  public class Competitor
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public int Id { get; set; }

    [Column(TypeName = "varchar(100)"), Required]
    public string FirstName { get; set; }

    [Column(TypeName = "varchar(100)"), Required]
    public string LastName { get; set; }

    public string NickName { get; set; }

    public ICollection<Result> Results { get; set; }


    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion


  }
}
