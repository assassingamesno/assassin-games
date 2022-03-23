using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Models.DTOs
{
    public class ParticipationDTO
    {
        public Guid ParticipationId { get; set; }
        public Guid UserId { get; set; }
        public Guid SeasonId { get; set; }
        public string Address { get; set; }
        public Guid UniversityAttendanceId { get; set; }
        public string Nickname { get; set; }
        public string Biography { get; set; }
        public string HangoutSpots { get; set; }
        public string Stores { get; set; }
    }
}
