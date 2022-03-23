using assassingames_backend.Models;
using assassingames_backend.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.DTOs.Mappers
{
    public static class OrganiserMapper
    {
        public static IEnumerable<OrganiserDTO> GetOrganisers(IEnumerable<Organiser> organisers)
        {
            IEnumerable<OrganiserDTO> organiserDTOs = organisers.Select(organiser =>
            new OrganiserDTO()
            {
                OrganiserId = organiser.OrganiserId,
                Name = organiser.Name,
                Country = organiser.Country,
                County = organiser.County,
                Municipality = organiser.Municipality
            });
            return organiserDTOs;
        }
        public static OrganiserDTO GetOrganiser(Organiser organiser)
        {
            OrganiserDTO organiserDTO = new()
            {
                OrganiserId = organiser.OrganiserId,
                Name = organiser.Name,
                Country = organiser.Country,
                County = organiser.County,
                Municipality = organiser.Municipality
            };
            return organiserDTO;
        }
    }
}
