using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace assassingames_backend.Models
{
    public class Organiser
    {
        public Guid OrganiserId { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Country { get; set; }
        public string County { get; set; }
        public string Municipality { get; set; }
        [JsonIgnore]
        public List<Season> Seasons { get; set; } = new List<Season>();
        [JsonIgnore]
        public List<Leadership> Leaderships { get; set; } = new List<Leadership>();
    }
}
