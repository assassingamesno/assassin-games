using assassingames_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Services.Interfaces
{
    public interface IParticipationService
    {
        public Participation GetParticipation(Guid participationId);
        public IEnumerable<Participation> GetParticipations();
        public void InsertParticipation(Participation participation);
        public void UpdateParticipation(Participation participation);
        public void DeleteParticipation(Guid participationId);
    }
}
