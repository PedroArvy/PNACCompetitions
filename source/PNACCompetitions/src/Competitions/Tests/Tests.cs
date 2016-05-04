using Competitions.Entities;
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


    private void AddCompetition(Club club)
    {
      Season season = Season.Get(_context, club, DateTime.Parse("23 March 2016"), DateTime.Parse("25 March 2016"));

      Competition comp1 = new Competition("Lake Fyans", DateTime.Parse("23 March 2016"), DateTime.Parse("25 March 2016"), ENVIRONMENT.FRESHWATER, season);
      _context.Add(comp1);
      _context.SaveChanges();
    }


    private void AddCompetitors(Club club)
    {
      Competitor competitor1 = new Competitor("Peter", "Swampy", "Patterson", club, Competitor.COMPETITOR_TYPE.SENIOR, Competitor.GENDER.MALE);
      _context.Add(competitor1);
      Competitor competitor2 = new Competitor("Eden", "", "Mallini", club, Competitor.COMPETITOR_TYPE.JUNIOR, Competitor.GENDER.FEMALE);
      _context.Add(competitor2);
      Competitor competitor3 = new Competitor("Andrew", "MadDog", "Barclay", club, Competitor.COMPETITOR_TYPE.SENIOR, Competitor.GENDER.MALE);
      _context.Add(competitor3);

      _context.SaveChanges();

      int count = _context.Clubs.Single(c => c.Id == club.Id).Competitors.Count();

      //IEnumerable<Competitor> competitors = _context.Competitors;
      //int no = competitors.Count();

      if (_context.Clubs.Single(c => c.Id == club.Id).Competitors.Count() != 3)
        throw new Exception("AddCompetitors 10");

      int competitor1Id = _context.Clubs.Single(c => c.Id == club.Id).Competitors.First().Id;
      int competitor2Id = _context.Clubs.Single(c => c.Id == club.Id).Competitors.Skip(1).First().Id;

      int no = _context.Competitors.Where(c => c.ClubId == club.Id).Count();

      if (no != 3)
        throw new Exception("AddCompetitors 20");

      if (_context.Competitors.SingleOrDefault(c => c.Id == competitor1Id) == null)
        throw new Exception("AddCompetitors 30");

      if (_context.Competitors.SingleOrDefault(c => c.Id == competitor2Id) == null)
        throw new Exception("AddCompetitors 40");


    }


    private void AddFish(Club club)
    {
      List<ENVIRONMENT> freshwater = new List<ENVIRONMENT>();
      freshwater.Add(ENVIRONMENT.FRESHWATER);

      List<ENVIRONMENT> all = new List<ENVIRONMENT>();
      freshwater.Add(ENVIRONMENT.FRESHWATER);
      freshwater.Add(ENVIRONMENT.SALTWATER);
      freshwater.Add(ENVIRONMENT.ESTUARY);

      Fish fish1 = new Fish(club, "Brown trout", 85, 28, 1, ENVIRONMENT.FRESHWATER);
      Fish fish2 = new Fish(club, "Rainbow trout", 85, 28, 1.2, ENVIRONMENT.FRESHWATER);
      Fish fish3 = new Fish(club, "Murray cod", 85, 28, 1.2, ENVIRONMENT.FRESHWATER);
      Fish fish4 = new Fish(club, "Bream", 45, 28, 1, ENVIRONMENT.ALL);

      _context.Fish.Add(fish1);
      _context.Fish.Add(fish2);
      _context.Fish.Add(fish3);
      _context.Fish.Add(fish4);

      _context.SaveChanges();

      if (_context.Clubs.Single(c => c.Id == club.Id).Fish.Count() != 4)
        throw new Exception("AddFish 10");

      _context.Fish.Remove(fish1);
      _context.Fish.Remove(fish2);
      _context.Fish.Remove(fish3);
      _context.Fish.Remove(fish4);
      _context.SaveChanges();

      if (_context.Clubs.Single(c => c.Id == club.Id).Fish.Count() != 0)
        throw new Exception("AddFish 20");

      fish1 = new Fish(club, "Brown trout", 85, 28, 1, ENVIRONMENT.FRESHWATER);
      fish2 = new Fish(club, "Rainbow trout", 85, 28, 1.2, ENVIRONMENT.FRESHWATER);
      fish3 = new Fish(club, "Murray cod", 85, 28, 1.2, ENVIRONMENT.FRESHWATER);
      fish4 = new Fish(club, "Bream", 45, 28, 1, ENVIRONMENT.ALL);

      _context.Fish.Add(fish1);
      _context.Fish.Add(fish2);
      _context.Fish.Add(fish3);
      _context.Fish.Add(fish4);

      _context.SaveChanges();

      if (_context.Clubs.Single(c => c.Id == club.Id).Fish.Count() != 4)
        throw new Exception("AddFish 30");

    }



    private void AddSeasons(Club club)
    {
      Season season1 = new Season(club, DateTime.Parse("5 September 2015"), DateTime.Parse("5 September 2016"));
      _context.Add(season1);

      Season season2 = new Season(club, DateTime.Parse("5 September 2016"), DateTime.Parse("5 September 2017"));
      _context.Add(season2);

      Season season3 = new Season(club, DateTime.Parse("5 September 2017"), DateTime.Parse("5 September 2018"));
      _context.Add(season3);

      _context.SaveChanges();

      IEnumerable<Season> seasons = _context.Seasons;
      int no = seasons.Count();

      if (_context.Clubs.Single(c => c.Id == club.Id).Seasons.Count() != 3)
        throw new Exception("AddSeasons 10");

      if (_context.Seasons.Where(s => s.ClubId == club.Id).Count() != 3)
        throw new Exception("AddSeasons 20");
    }


    public void Construction()
    {
      Club club = AddClub();

      AddFish(club);
      int clubId = club.Id;

      AddSeasons(club);

      int season1Id = club.Seasons.First().Id;
      int season2Id = club.Seasons.Skip(1).First().Id;

      AddCompetitors(club);

      AddCompetition(club);

      AddCatch(club);

      _context.Clubs.Remove(club);
      _context.SaveChanges();

      if (_context.Seasons.SingleOrDefault(s => s.Id == season1Id) != null)
        throw new Exception("Construction 10");

      if (_context.Seasons.SingleOrDefault(s => s.Id == season2Id) != null)
        throw new Exception("Construction 20");

      if (_context.Competitors.SingleOrDefault(c => c.ClubId == clubId) != null)
        throw new Exception("Construction 30");


    }


    #endregion



  }
}
