using assassingames_backend.Models;
using assassingames_backend.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.DTOs.Mappers
{
    public static class PrizeMapper
    {
        public static IEnumerable<PrizeDTO> GetPrizes(IEnumerable<Prize> prizes)
        {
            IEnumerable<PrizeDTO> prizeDTOs = prizes.Select(prize =>
            new PrizeDTO()
            {
                PrizeId = prize.PrizeId,
                PrizeDescription = prize.PrizeDescription,
                TaskDescription = prize.TaskDescription,
                Provider = prize.Provider,
                Value = prize.Value,
                SeasonId = prize.SeasonId
            });
            return prizeDTOs;
        }
        public static PrizeDTO GetPrize(Prize prize)
        {
            PrizeDTO prizeDTO = new()
            {
                PrizeId = prize.PrizeId,
                PrizeDescription = prize.PrizeDescription,
                TaskDescription = prize.TaskDescription,
                Provider = prize.Provider,
                Value = prize.Value,
                SeasonId = prize.SeasonId
            };
            return prizeDTO;
        }
    }
}
