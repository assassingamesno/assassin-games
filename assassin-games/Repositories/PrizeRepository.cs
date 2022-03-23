using assassingames_backend.DbContexts;
using assassingames_backend.Models;
using assassingames_backend.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Repositories
{
    public class PrizeRepository : IPrizeRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public PrizeRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public void DeletePrize(Guid prizeId)
        {
            Prize prize = _applicationDbContext.Prizes.Find(prizeId);
            _applicationDbContext.Prizes.Remove(prize);
            _applicationDbContext.SaveChanges();
        }

        public Prize GetPrize(Guid prizeId)
        {
            return _applicationDbContext.Prizes.Find(prizeId);
        }

        public IEnumerable<Prize> GetPrizes()
        {
            return _applicationDbContext.Prizes;
        }

        public void InsertPrize(Prize prize)
        {
            _applicationDbContext.Prizes.Add(prize);
            _applicationDbContext.SaveChanges();
        }

        public void UpdatePrize(Prize prize)
        {
            _applicationDbContext.Prizes.Update(prize);
            _applicationDbContext.SaveChanges();
        }
    }
}
