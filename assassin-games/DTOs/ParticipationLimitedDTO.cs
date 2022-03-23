using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Models.DTOs
{
    public class ParticipationLimitedDTO
    {
        public Guid ParticipationId { get; set; }
        public Guid UserId { get; set; }
        public Guid SeasonId { get; set; }
    }
}
