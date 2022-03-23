using assassingames_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Repositories.Interfaces
{
    public interface IOrganiserRepository
    {
        public Organiser GetOrganiser(Guid organiserId);
        public IEnumerable<Organiser> GetOrganisers();
        public void InsertOrganiser(Organiser organiser);
        public void UpdateOrganiser(Organiser organiser);
        public void DeleteOrganiser(Guid organiserId);
    }
}
