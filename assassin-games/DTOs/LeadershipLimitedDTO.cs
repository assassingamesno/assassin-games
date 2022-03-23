using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace assassingames_backend.Models.DTOs
{
    public class LeadershipLimitedDTO
    {
        public Guid LeadershipId { get; set; }
        public Guid UserId { get; set; }
        public Guid OrganiserId { get; set; }
    }
}