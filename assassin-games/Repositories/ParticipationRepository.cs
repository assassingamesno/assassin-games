using assassingames_backend.DbContexts;
using assassingames_backend.Models;
using assassingames_backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Repositories
{
    public class ParticipationRepository : IParticipationRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public ParticipationRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public void DeleteParticipation(Guid participationId)
        {
            Participation participation = _applicationDbContext.Participations.Find(participationId);
            _applicationDbContext.Participations.Remove(participation);
            _applicationDbContext.SaveChanges();
        }

        public Participation GetParticipation(Guid participationId)
        {
            return _applicationDbContext.Participations.Find(participationId);
        }

        public IEnumerable<Participation> GetParticipations()
        {
            return _applicationDbContext.Participations.Include(p => p.User).Include(p => p.Season).Include(p => p.UniversityAttendance).ThenInclude(u => u.Study);
        }

        public void InsertParticipation(Participation participation)
        {
            _applicationDbContext.Participations.Add(participation);
            _applicationDbContext.SaveChanges();
        }

        public void UpdateParticipation(Participation participation)
        {
            _applicationDbContext.Participations.Update(participation);
            _applicationDbContext.SaveChanges();
        }
    }
}
