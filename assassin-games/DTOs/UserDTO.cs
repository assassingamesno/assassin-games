using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Models.DTOs
{
    public class UserDTO
    {
        public Guid UserId { get; set; }
        public string EMail { get; set; }
        public string Name { get; set; }
        public string InstagramHandle { get; set; }
    }
}
