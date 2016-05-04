﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Competitions.Entities
{
  public class Club
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public int Id { get; set; }

    public List<Competitor> Competitors { get; set; }

    [Column(TypeName = "varchar(100)"), Required]
    public string Name { get; set; }

    public List<Season> Seasons { get; set; }

    public List<Fish> Fish { get; set; }

    #endregion


    #region *********************** Initialisation *******************


    public Club()
    {
    }


    public Club(string name)
    {
      Name = name;
    }

    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}