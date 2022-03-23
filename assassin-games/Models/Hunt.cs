using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace assassingames_backend.Models
{
    public class Hunt
    {
        public Guid HuntId { get; set; } = Guid.NewGuid();
        public int Status { get; set; } = 0; //0: General inactive; 1: Active; 2: Killed; 3: Inactive due to other death;
        public Guid AssassinId { get; set; }
        [JsonIgnore]
        public Participation Assassin { get; set; }
        public Guid TargetId { get; set; }
        [JsonIgnore]
        public Participation Target { get; set; }
        public DateTime? KillTime { get; set; }
    }
}
