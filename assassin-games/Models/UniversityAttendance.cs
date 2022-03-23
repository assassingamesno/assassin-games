using System;

namespace assassingames_backend.Models
{
    public class UniversityAttendance
    {
        public Guid UniversityAttendanceId { get; set; } = Guid.NewGuid();
        public Participation Participation { get; set; }
        public Study Study { get; set; }
        public Guid StudyId { get; set; }
        public int Year { get; set; }
        public string Note { get; set; }
    }
}
