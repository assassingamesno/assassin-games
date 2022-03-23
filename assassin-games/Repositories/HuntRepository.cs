using assassingames_backend.DbContexts;
using assassingames_backend.Models;
using assassingames_backend.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Repositories
{
    public class HuntRepository : IHuntRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public HuntRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public void DeleteHunt(Guid huntId)
        {
            Hunt hunt = _applicationDbContext.Hunts.Find(huntId);
            _applicationDbContext.Hunts.Remove(hunt);
            _applicationDbContext.SaveChanges();
        }

        public Hunt GetHunt(Guid huntId)
        {
            return _applicationDbContext.Hunts.Find(huntId);
        }

        public IEnumerable<Hunt> GetHunts()
        {
            return _applicationDbContext.Hunts;
        }

        public void InsertHunt(Hunt hunt)
        {
            _applicationDbContext.Hunts.Add(hunt);
            _applicationDbContext.SaveChanges();
        }

        public void UpdateHunt(Hunt hunt)
        {
            _applicationDbContext.Hunts.Update(hunt);
            _applicationDbContext.SaveChanges();
        }
    }
}
