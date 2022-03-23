using assassingames_backend.DbContexts;
using assassingames_backend.Models;
using assassingames_backend.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Repositories
{
    public class SeasonRepository : ISeasonRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public SeasonRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public void DeleteSeason(Guid seasonId)
        {
            Season season = _applicationDbContext.Seasons.Find(seasonId);
            _applicationDbContext.Seasons.Remove(season);
            _applicationDbContext.SaveChanges();
        }

        public Season GetSeason(Guid seasonId)
        {
            return _applicationDbContext.Seasons.Find(seasonId);
        }

        public IEnumerable<Season> GetSeasons()
        {
            return _applicationDbContext.Seasons;
        }

        public void InsertSeason(Season season)
        {
            _applicationDbContext.Seasons.Add(season);
            _applicationDbContext.SaveChanges();
        }

        public void UpdateSeason(Season season)
        {
            _applicationDbContext.Seasons.Update(season);
            _applicationDbContext.SaveChanges();
        }
    }
}
