using assassingames_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Services.Interfaces
{
    public interface ISeasonService
    {
        public Season GetSeason(Guid seasonId);
        public IEnumerable<Season> GetSeasons();
        public void InsertSeason(Season season);
        public void UpdateSeason(Season season);
        public void DeleteSeason(Guid seasonId);
    }
}
