using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Models.DTOs
{
    public class OrganiserDTO
    {
        public Guid OrganiserId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string County { get; set; }
        public string Municipality { get; set; }
    }
}
