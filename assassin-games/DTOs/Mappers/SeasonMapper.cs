using assassingames_backend.Models;
using assassingames_backend.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.DTOs.Mappers
{
    public static class SeasonMapper
    {
        public static IEnumerable<SeasonDTO> GetSeasons(IEnumerable<Season> seasons)
        {
            IEnumerable<SeasonDTO> seasonDTOs = seasons.Select(season =>
            new SeasonDTO()
            {
                SeasonId = season.SeasonId,
                SeasonNumber = season.SeasonNumber,
                SeasonStart = season.SeasonStart,
                SeasonEnd = season.SeasonEnd,
                OrganiserId = season.OrganiserId,
                RegistrationStart = season.RegistrationStart,
                RegistrationEnd = season.RegistrationEnd,
                Phase = season.Phase
            });
            return seasonDTOs;
        }
        public static SeasonDTO GetSeason(Season season)
        {
            SeasonDTO seasonDTO = new()
            {
                SeasonId = season.SeasonId,
                SeasonNumber = season.SeasonNumber,
                SeasonStart = season.SeasonStart,
                SeasonEnd = season.SeasonEnd,
                OrganiserId = season.OrganiserId,
                RegistrationStart = season.RegistrationStart,
                RegistrationEnd = season.RegistrationEnd,
                Phase = season.Phase
            };
            return seasonDTO;
        }
    }
}
