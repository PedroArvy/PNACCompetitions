using Competitions.POCO;
using Microsoft.Data.Entity;
using System.Collections.Generic;

namespace Competitions.Services
{
  public interface ICompetitionData
  {
    void Add(Club club);
    void Add(Season season);

    IEnumerable<Club> Clubs();

    void Delete(Club club);
    void Delete(Season season);


    IEnumerable<Season> Seasons();
  }
}
