using Competitions.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competitions.Stores
{
  public interface ICompetitonStore
  {
    void Add(Competition competition);
    void Add(Competitor competitor);
    void Add(Fish fish);
    void Add(Result result);
    void Add(Season season);
  }
}
