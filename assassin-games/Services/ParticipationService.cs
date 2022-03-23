using assassingames_backend.DbContexts;
using assassingames_backend.Models;
using assassingames_backend.Repositories.Interfaces;
using assassingames_backend.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Services
{
    public class ParticipationService : IParticipationService
    {
        private readonly IParticipationRepository _participationRepository;
        public ParticipationService(IParticipationRepository participationRepository)
        {
            _participationRepository = participationRepository;
        }
        public void DeleteParticipation(Guid participationId)
        {
            _participationRepository.DeleteParticipation(participationId);
        }

        public Participation GetParticipation(Guid participationId)
        {
            return _participationRepository.GetParticipation(participationId);
        }

        public IEnumerable<Participation> GetParticipations()
        {
            return _participationRepository.GetParticipations();
        }

        public void InsertParticipation(Participation participation)
        {
            _participationRepository.InsertParticipation(participation);
        }

        public void UpdateParticipation(Participation participation)
        {
            _participationRepository.UpdateParticipation(participation);
        }
    }
}
