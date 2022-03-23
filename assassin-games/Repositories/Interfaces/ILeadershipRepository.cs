using assassingames_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Repositories.Interfaces
{
    public interface ILeadershipRepository
    {
        public Leadership GetLeadership(Guid leadershipId);
        public IEnumerable<Leadership> GetLeaderships();
        public void InsertLeadership(Leadership leadership);
        public void UpdateLeadership(Leadership leadership);
        public void DeleteLeadership(Guid leadershipId);
    }
}
