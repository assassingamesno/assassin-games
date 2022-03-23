using assassingames_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Services.Interfaces
{
    public interface ILeadershipService
    {
        public Leadership GetLeadership(Guid leadershipId);
        public IEnumerable<Leadership> GetLeaderships();
        public void InsertLeadership(Leadership leadership);
        public void UpdateLeadership(Leadership leadership);
        public void DeleteLeadership(Guid leadershipId);
    }
}
