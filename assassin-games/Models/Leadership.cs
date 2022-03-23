using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace assassingames_backend.Models
{
    public class Leadership
    {
        public Guid LeadershipId { get; set; } = Guid.NewGuid();
        public DateTime LeadershipStart { get; set; }
        public DateTime? LeadershipEnd { get; set; }
        public Guid UserId { get; set; }
        [JsonIgnore]
        public User User { get; set; }
        public Guid OrganiserId { get; set; }
        [JsonIgnore] 
        public Organiser Organiser { get; set; }
    }
}
