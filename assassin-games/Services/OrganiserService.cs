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
    public class OrganiserService : IOrganiserService
    {
        private readonly IOrganiserRepository _organiserRepository;
        public OrganiserService(IOrganiserRepository organiserRepository)
        {
            _organiserRepository = organiserRepository;
        }
        public void DeleteOrganiser(Guid organiserId)
        {
            _organiserRepository.DeleteOrganiser(organiserId);
        }

        public Organiser GetOrganiser(Guid organiserId)
        {
            return _organiserRepository.GetOrganiser(organiserId);
        }

        public IEnumerable<Organiser> GetOrganisers()
        {
            return _organiserRepository.GetOrganisers();
        }

        public void InsertOrganiser(Organiser organiser)
        {
            _organiserRepository.InsertOrganiser(organiser);
        }

        public void UpdateOrganiser(Organiser organiser)
        {
            _organiserRepository.UpdateOrganiser(organiser);
        }
    }
}
