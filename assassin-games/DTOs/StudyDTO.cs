using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.DTOs
{
    public class StudyDTO
    {
        public Guid StudyId { get; set; }
        public string StudyName { get; set; }
        public string Campus { get; set; }
        public string University { get; set; }
    }
}
