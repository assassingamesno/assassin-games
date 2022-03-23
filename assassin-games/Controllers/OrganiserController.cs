using assassingames_backend.DTOs.Mappers;
using assassingames_backend.Models;
using assassingames_backend.Models.DTOs;
using assassingames_backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class OrganiserController : Controller
    {
        private readonly IOrganiserService _organiserService;
        public OrganiserController(IOrganiserService organiserService)
        {
            _organiserService = organiserService;
        }
        [HttpGet]
        public IActionResult GetOrganisers()
        {
            IEnumerable<Organiser> organisers = _organiserService.GetOrganisers();
            return Ok(OrganiserMapper.GetOrganisers(organisers));
        }
        [HttpGet("{organiserId}")]
        public IActionResult GetOrganiser(Guid organiserId)
        {
            Organiser organiser = _organiserService.GetOrganiser(organiserId);
            return organiser == null ? NotFound() : Ok(OrganiserMapper.GetOrganiser(organiser));
        }
        [HttpPost]
        public IActionResult InsertOrganiser([FromBody] Organiser organiser)
        {
            if (!ModelState.IsValid)
                return BadRequest("Organiser object is not valid");
            _organiserService.InsertOrganiser(organiser);
            return Created("~api/Organiser/" + organiser.OrganiserId.ToString(), organiser);
        }
        [HttpPut]
        public IActionResult UpdateOrganiser([FromBody] Organiser organiser)
        {
            _organiserService.UpdateOrganiser(organiser);
            return Ok();
        }
        [HttpDelete("{organiserId}")]
        public IActionResult DeleteOrganiser(Guid organiserId)
        {
            _organiserService.DeleteOrganiser(organiserId);
            return Ok();
        }
    }
}
