using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace assassingames_backend.Models
{
    public class Prize
    {
        public Guid PrizeId { get; set; } = Guid.NewGuid();
        public string PrizeDescription { get; set; }
        public string TaskDescription { get; set; }
        public string Provider { get; set; }
        public int Value { get; set; }
        public Guid SeasonId { get; set; }
        [JsonIgnore]
        public Season Season { get; set; }
    }
}
