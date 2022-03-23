using assassingames_backend.DbContexts;
using assassingames_backend.Models;
using assassingames_backend.Repositories.Interfaces;
using assassingames_backend.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Services
{
    public class SeasonService : ISeasonService
    {
        private readonly ISeasonRepository _seasonRepository;
        public SeasonService(ISeasonRepository seasonRepository)
        {
            _seasonRepository = seasonRepository;
        }
        public void DeleteSeason(Guid seasonId)
        {
            _seasonRepository.DeleteSeason(seasonId);
        }

        public Season GetSeason(Guid seasonId)
        {
            return _seasonRepository.GetSeason(seasonId);
        }

        public IEnumerable<Season> GetSeasons()
        {
            return _seasonRepository.GetSeasons();
        }

        public void InsertSeason(Season season)
        {
            _seasonRepository.InsertSeason(season);
        }

        public void UpdateSeason(Season season)
        {
            _seasonRepository.UpdateSeason(season);
        }
    }
}
