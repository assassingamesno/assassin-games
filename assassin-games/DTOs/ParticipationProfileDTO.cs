using System;

namespace assassingames_backend.DTOs
{
    public class ParticipationProfileDTO
    {
        public Guid ParticipationId { get; set; }
        public Guid UserId { get; set; }
        public int SeasonNumber { get; set; }
        public Guid UniversityAttendanceId { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string NameWithNick { get; set; }
        public string InstagramHandle { get; set; }
        public string Biography { get; set; }
        public string HangoutSpots { get; set; }
        public string Stores { get; set; }
        public string StudyName { get; set; }
        public string Campus { get; set; }
    }
}
