using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Models
{
    public class Study
    {
        public Guid StudyId { get; set; } = Guid.NewGuid();
        public string StudyName { get; set; }
        public string Campus { get; set; }
        public string University { get; set; }
        public List<UniversityAttendance> UniversityAttendances { get; set; } = new List<UniversityAttendance>();
        public string Level { get; set; }
        public int Length { get; set; }
    }
}
