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
    public class LeadershipRepository : ILeadershipRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public LeadershipRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public void DeleteLeadership(Guid leadershipId)
        {
            Leadership leadership = _applicationDbContext.Leaderships.Find(leadershipId);
            _applicationDbContext.Leaderships.Remove(leadership);
            _applicationDbContext.SaveChanges();
        }

        public Leadership GetLeadership(Guid leadershipId)
        {
            return _applicationDbContext.Leaderships
                .Include(leadership => leadership.User)
                .FirstOrDefault(leadership => leadership.LeadershipId == leadershipId);
        }

        public IEnumerable<Leadership> GetLeaderships()
        {
            return _applicationDbContext.Leaderships;
        }

        public void InsertLeadership(Leadership leadership)
        {
            _applicationDbContext.Leaderships.Add(leadership);
            _applicationDbContext.SaveChanges();
        }

        public void UpdateLeadership(Leadership leadership)
        {
            _applicationDbContext.Leaderships.Update(leadership);
            _applicationDbContext.SaveChanges();
        }
    }
}
