using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace assassingames_backend.Models
{
    public class Participation
    {
        public Guid ParticipationId { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        [JsonIgnore]
        public User User { get; set; }
        public Guid SeasonId { get; set; }
        [JsonIgnore]
        public Season Season { get; set; }
        public string Address { get; set; }
        public Guid? UniversityAttendanceId { get; set; }
        [JsonIgnore]
        public UniversityAttendance UniversityAttendance { get; set; }
        public string Nickname { get; set; }
        public string Biography { get; set; }
        public string HangoutSpots { get; set; }
        public string Stores { get; set; }
        [InverseProperty("Target")]
        [JsonIgnore]
        public List<Hunt> Hunteds { get; set; }
        [InverseProperty("Assassin")]
        [JsonIgnore]
        public List<Hunt> Hunts { get; set; }
        public bool FeePaid { get; set; }
        public string Animal { get; set; }
        public string Food { get; set; }
        public string Colour { get; set; }
        public string Skill { get; set; }
        public string Obituary { get; set; }
    }
}
