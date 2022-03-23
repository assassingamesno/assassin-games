using assassingames_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Repositories.Interfaces
{
    public interface IHuntRepository
    {
        public Hunt GetHunt(Guid huntId);
        public IEnumerable<Hunt> GetHunts();
        public void InsertHunt(Hunt hunt);
        public void UpdateHunt(Hunt hunt);
        public void DeleteHunt(Guid huntId);
    }
}
