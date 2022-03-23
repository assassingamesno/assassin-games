using assassingames_backend.Models;
using assassingames_backend.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.DTOs.Mappers
{
    public static class ParticipationMapper
    {
        public static IEnumerable<ParticipationLimitedDTO> GetParticipations(IEnumerable<Participation> participations)
        {
            IEnumerable<ParticipationLimitedDTO> participationDTOs = participations.Select(participation =>
            new ParticipationLimitedDTO
            {
                ParticipationId = participation.ParticipationId,
                UserId = participation.UserId,
                SeasonId = participation.SeasonId
            });
            return participationDTOs;
        }
        public static ParticipationDTO GetParticipation(Participation participation)
        {
            ParticipationDTO participationDTO = new()
            {
                ParticipationId = participation.ParticipationId,
                UserId = participation.UserId,
                SeasonId = participation.SeasonId,
                Address = participation.Address,
                Nickname = participation.Nickname,
                Biography = participation.Biography,
                HangoutSpots = participation.HangoutSpots,
                Stores = participation.Stores
            };
            return participationDTO;
        }
        public static IEnumerable<ParticipationProfileDTO> GetParticipationProfiles(IEnumerable<Participation> participations)
        {
            IEnumerable<ParticipationProfileDTO> participationProfileDTOs = participations.Select(participation =>
                new ParticipationProfileDTO
                {
                    ParticipationId = participation.ParticipationId,
                    UserId = participation.UserId,
                    SeasonNumber = participation.Season.SeasonNumber,
                    Name = participation.User.Name,
                    Nickname = participation.Nickname,
                    NameWithNick = participation.User.Name
                    .Split(" ")
                    .First() + " \"" + participation.Nickname + "\" " +
                    participation.User.Name.Split(" ")
                    .Last(),
                    InstagramHandle = participation.User.InstagramHandle,
                    Biography = participation.Biography,
                    HangoutSpots = participation.HangoutSpots,
                    Stores = participation.Stores,
                    StudyName = "Temp",
                    Campus = "Temp"
                    //StudyName = participation.UniversityAttendance.Study.StudyName,
                    //Campus = participation.UniversityAttendance.Study.Campus
                });
            return participationProfileDTOs;
        }
    }
}
