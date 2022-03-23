using assassingames_backend.Models;
using assassingames_backend.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.DTOs.Mappers
{
    public static class LeadershipMapper
    {
        public static IEnumerable<LeadershipLimitedDTO> GetLeaderships(IEnumerable<Leadership> leaderships)
        {
            IEnumerable<LeadershipLimitedDTO> leadershipDTOs = leaderships.Select(leadership =>
            new LeadershipLimitedDTO
            {
                LeadershipId = leadership.LeadershipId,
                UserId = leadership.UserId,
                OrganiserId = leadership.OrganiserId
            });
            return leadershipDTOs;
        }
        public static LeadershipDTO GetLeadership(Leadership leadership)
        {
            LeadershipDTO leadershipDTO = new()
            {
                LeadershipId = leadership.LeadershipId,
                LeadershipStart = leadership.LeadershipStart,
                LeadershipEnd = leadership.LeadershipEnd,
                UserId = leadership.UserId,
                OrganiserId = leadership.OrganiserId
            };
            return leadershipDTO;
        }
    }
}
