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
    public class PrizeService : IPrizeService
    {
        private readonly IPrizeRepository _prizeRepository;
        public PrizeService(IPrizeRepository prizeRepository)
        {
            _prizeRepository = prizeRepository;
        }
        public void DeletePrize(Guid prizeId)
        {
            _prizeRepository.DeletePrize(prizeId);
        }

        public Prize GetPrize(Guid prizeId)
        {
            return _prizeRepository.GetPrize(prizeId);
        }

        public IEnumerable<Prize> GetPrizes()
        {
            return _prizeRepository.GetPrizes();
        }

        public void InsertPrize(Prize prize)
        {
            _prizeRepository.InsertPrize(prize);
        }

        public void UpdatePrize(Prize prize)
        {
            _prizeRepository.UpdatePrize(prize);
        }
    }
}
