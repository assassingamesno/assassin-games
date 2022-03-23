using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Models.DTOs
{
    public class PrizeDTO
    {
        public Guid PrizeId { get; set; }
        public string PrizeDescription { get; set; }
        public string TaskDescription { get; set; }
        public string Provider { get; set; }
        public int Value { get; set; }
        public Guid SeasonId { get; set; }
    }
}
