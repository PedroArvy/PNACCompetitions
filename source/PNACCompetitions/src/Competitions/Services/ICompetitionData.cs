using Competitions.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competitions.Stores
{
  public interface ICompetitionStore
  {
    void Add(Club club);
    void Add(Season season);
  }
}
