using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Models.DTOs
{
    public class SeasonDTO
    {
        public Guid SeasonId { get; set; }
        public int SeasonNumber { get; set; }
        public DateTime SeasonStart { get; set; }
        public DateTime? SeasonEnd { get; set; }
        public Guid OrganiserId { get; set; }
        public DateTime RegistrationStart { get; set; }
        public DateTime RegistrationEnd { get; set; }
        public int Phase { get; set; }
    }
}
