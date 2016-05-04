using Competitions.Entities;
using Competitions.POCO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Competitions.Tests
{
  public class Tests
  {
    #region *********************** Constants ************************

    private CompetitionDbContext _context;

    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************
    #endregion


    #region *********************** Initialisation *******************

    public Tests(CompetitionDbContext context)
    {
      _context = context;
    }

    #endregion


    #region *********************** Methods **************************


    private Club AddClub()
    {
      Club prestonNorthcote = new Club("Northern Suburbs Fly Fishing Club");
      _context.Add(prestonNorthcote);

      _context.SaveChanges();
      int clubId = prestonNorthcote.Id;

      if (_context.Clubs.SingleOrDefault(s => s.Id == clubId) == null)
        throw new Exception("AddClub 10");

      return prestonNorthcote;
    }


    private void AddCompetitors(Club club)
    {
      Competitor competitor1 = new Competitor("Peter", "Swampy", "Patterson", club, Competitor.COMPETITOR_TYPE.SENIOR, Competitor.GENDER.MALE);
      _context.Add(competitor1);
      Competitor competitor2 = new Competitor("Eden", "", "Mallini", club, Competitor.COMPETITOR_TYPE.JUNIOR, Competitor.GENDER.FEMALE);
      _context.Add(competitor2);

      _context.SaveChanges();

      int count = _context.Clubs.Single(c => c.Id == club.Id).Competitors.Count();

      //IEnumerable<Competitor> competitors = _context.Competitors;
      //int no = competitors.Count();

      if (_context.Clubs.Single(c => c.Id == club.Id).Competitors.Count() != 2)
        throw new Exception("AddCompetitors 10");
    }


    private void AddSeasons(Club club)
    {
      Season season1 = new Season(club, DateTime.Parse("5 September 2016"), DateTime.Parse("5 September 2017"));
      _context.Add(season1);

      Season season2 = new Season(club, DateTime.Parse("5 September 2017"), DateTime.Parse("5 September 2018"));
      _context.Add(season2);

      _context.SaveChanges();

      IEnumerable<Season> seasons = _context.Seasons;
      int no = seasons.Count();

      if (_context.Clubs.Single(c => c.Id == club.Id).Seasons.Count() != 2)
        throw new Exception("AddSeasons 10");

      if (_context.Seasons.Where(s => s.ClubId == club.Id).Count() != 2)
        throw new Exception("AddSeasons 20");
    }


    public void Construction()
    {
      Club club = AddClub();

      AddSeasons(club);

      int season1Id = club.Seasons.First().Id;
      int season2Id = club.Seasons.Skip(1).First().Id;

      AddCompetitors(club);

      int competitor1Id = _context.Clubs.Single(c => c.Id == club.Id).Competitors.First().Id;
      int competitor2Id = _context.Clubs.Single(c => c.Id == club.Id).Competitors.Skip(1).First().Id;

      int no = _context.Competitors.Where(c => c.ClubId == club.Id).Count();

      if(no != 2)
        throw new Exception("Construction 5");

      if (_context.Competitors.SingleOrDefault(c => c.Id == competitor1Id) == null)
        throw new Exception("Construction 10");

      if (_context.Competitors.SingleOrDefault(c => c.Id == competitor2Id) == null)
        throw new Exception("Construction 15");


      _context.Clubs.Remove(club);
      _context.SaveChanges();

      if (_context.Seasons.SingleOrDefault(s => s.Id == season1Id) != null)
        throw new Exception("Construction 10");

      if (_context.Seasons.SingleOrDefault(s => s.Id == season2Id) != null)
        throw new Exception("Construction 20");


      no = _context.Competitors.Where(c => c.Id == competitor1Id).Count();

      if (_context.Competitors.SingleOrDefault(c => c.Id == competitor1Id) != null)
        throw new Exception("Construction 30");

      if (_context.Competitors.SingleOrDefault(c => c.Id == competitor2Id) != null)
        throw new Exception("Construction 40");
    }


    #endregion



  }
}
