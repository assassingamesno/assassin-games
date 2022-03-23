using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Models.DTOs
{
    public class RuleDTO
    {
        public Guid RuleId { get; set; }
        public string Description { get; set; }
        public int Phase { get; set; }
        public DateTime Added { get; set; }
        public Guid SeasonId { get; set; }
    }
}
