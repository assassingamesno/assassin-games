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
    public class HuntService : IHuntService
    {
        private readonly IHuntRepository _huntRepository;
        public HuntService(IHuntRepository huntRepository)
        {
            _huntRepository = huntRepository;
        }
        public void DeleteHunt(Guid huntId)
        {
            _huntRepository.DeleteHunt(huntId);
        }

        public Hunt GetHunt(Guid huntId)
        {
            return _huntRepository.GetHunt(huntId);
        }

        public IEnumerable<Hunt> GetHunts()
        {
            return _huntRepository.GetHunts();
        }

        public void InsertHunt(Hunt hunt)
        {
            _huntRepository.InsertHunt(hunt);
        }

        public void UpdateHunt(Hunt hunt)
        {
            _huntRepository.UpdateHunt(hunt);
        }
    }
}
