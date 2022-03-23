using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace assassingames_backend.Models
{
    public class User
    {
        public Guid UserId { get; set; } = Guid.NewGuid();
        public string EMail { get; set; }
        public string Name { get; set; }
        public string InstagramHandle { get; set; }
        [JsonIgnore]
        public List<Leadership> Leaderships { get; set; }
        [JsonIgnore]
        public List<Participation> Participations { get; set; }
    }
}
