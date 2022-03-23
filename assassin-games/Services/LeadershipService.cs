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
    public class LeadershipService : ILeadershipService
    {
        private readonly ILeadershipRepository _leadershipRepository;
        public LeadershipService(ILeadershipRepository leadershipRepository)
        {
            _leadershipRepository = leadershipRepository;
        }
        public void DeleteLeadership(Guid leadershipId)
        {
            _leadershipRepository.DeleteLeadership(leadershipId);
        }

        public Leadership GetLeadership(Guid leadershipId)
        {
            return _leadershipRepository.GetLeadership(leadershipId);
        }

        public IEnumerable<Leadership> GetLeaderships()
        {
            return _leadershipRepository.GetLeaderships();
        }

        public void InsertLeadership(Leadership leadership)
        {
            _leadershipRepository.InsertLeadership(leadership);
        }

        public void UpdateLeadership(Leadership leadership)
        {
            _leadershipRepository.UpdateLeadership(leadership);
        }
    }
}
