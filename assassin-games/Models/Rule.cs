using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace assassingames_backend.Models
{
    public class Rule
    {
        public Guid RuleId { get; set; } = Guid.NewGuid();
        public string Description { get; set; }
        public int Phase { get; set; }
        public DateTime Added { get; set; }
        public Guid SeasonId { get; set; }
        [JsonIgnore]
        public Season Season { get; set; }
    }
}
