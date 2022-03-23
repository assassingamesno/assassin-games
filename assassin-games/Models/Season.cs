using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace assassingames_backend.Models
{
    public class Season
    {
        public Guid SeasonId { get; set; } = Guid.NewGuid();
        [Required]
        public int SeasonNumber { get; set; }
        public DateTime SeasonStart { get; set; }
        public DateTime? SeasonEnd { get; set; }
        [Required]
        public Guid OrganiserId { get; set; }
        [JsonIgnore]
        public Organiser Organiser { get; set; }
        public DateTime RegistrationStart { get; set; }
        public DateTime RegistrationEnd { get; set; }
        public int Phase { get; set; } = 0;
        public int Limit { get; set; }
        [JsonIgnore]
        public List<Participation> Participations { get; set; } = new List<Participation>();
        [JsonIgnore]
        public List<Prize> Prizes { get; set; } = new List<Prize>();
        [JsonIgnore]
        public List<Rule> Rules { get; set; } = new List<Rule>();
    }
}
