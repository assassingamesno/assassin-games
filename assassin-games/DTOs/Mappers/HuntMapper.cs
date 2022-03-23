using assassingames_backend.Models;
using assassingames_backend.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.DTOs.Mappers
{
    public static class HuntMapper
    {
        public static IEnumerable<HuntDTO> GetHunts(IEnumerable<Hunt> hunts)
        {
            IEnumerable<HuntDTO> huntDTOs = hunts.Select(hunt =>
            new HuntDTO()
            {
                HuntId = hunt.HuntId,
                Status = hunt.Status,
                AssassinId = hunt.AssassinId,
                TargetId = hunt.TargetId,
                KillTime = hunt.KillTime
            });
            return huntDTOs;
        }
        public static HuntDTO GetHunt(Hunt hunt)
        {
            HuntDTO huntDTO = new()
            {
                HuntId = hunt.HuntId,
                Status = hunt.Status,
                AssassinId = hunt.AssassinId,
                TargetId = hunt.TargetId,
                KillTime = hunt.KillTime
            };
            return huntDTO;
        }
    }
}
