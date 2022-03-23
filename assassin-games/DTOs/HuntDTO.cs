using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Models.DTOs
{
    public class HuntDTO
    {
        public Guid HuntId { get; set; }
        public int Status { get; set; }
        public Guid AssassinId { get; set; }
        public Guid TargetId { get; set; }
        public DateTime? KillTime { get; set; }
    }
}
