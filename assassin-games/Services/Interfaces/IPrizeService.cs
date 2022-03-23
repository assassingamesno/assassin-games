using assassingames_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Services.Interfaces
{
    public interface IPrizeService
    {
        public Prize GetPrize(Guid prizeId);
        public IEnumerable<Prize> GetPrizes();
        public void InsertPrize(Prize prize);
        public void UpdatePrize(Prize prize);
        public void DeletePrize(Guid prizeId);
    }
}
