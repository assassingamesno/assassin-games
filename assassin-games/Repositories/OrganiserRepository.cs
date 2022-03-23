using assassingames_backend.DbContexts;
using assassingames_backend.Models;
using assassingames_backend.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Repositories
{
    public class OrganiserRepository : IOrganiserRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public OrganiserRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public void DeleteOrganiser(Guid organiserId)
        {
            Organiser organiser = _applicationDbContext.Organisers.Find(organiserId);
            _applicationDbContext.Organisers.Remove(organiser);
            _applicationDbContext.SaveChanges();
        }

        public Organiser GetOrganiser(Guid organiserId)
        {
            return _applicationDbContext.Organisers.Find(organiserId);
        }

        public IEnumerable<Organiser> GetOrganisers()
        {
            return _applicationDbContext.Organisers;
        }

        public void InsertOrganiser(Organiser organiser)
        {
            _applicationDbContext.Organisers.Add(organiser);
            _applicationDbContext.SaveChanges();
        }

        public void UpdateOrganiser(Organiser organiser)
        {
            _applicationDbContext.Organisers.Update(organiser);
            _applicationDbContext.SaveChanges();
        }
    }
}
