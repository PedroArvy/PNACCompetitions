﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Models.ViewModels.Catches
{
  public class CompetitionCatches
  {
    public List<CompetitorCatch> Catches { get; set; }

    public int CompetitonId { get; set; }

    public bool ShowDay { get; set; }
  }
}


