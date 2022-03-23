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
    public class ParticipationController : Controller
    {
        private readonly IParticipationService _participationService;
        public ParticipationController(IParticipationService participationService)
        {
            _participationService = participationService;
        }
        [HttpGet]
        public IActionResult GetParticipations()
        {
            IEnumerable<Participation> participations = _participationService.GetParticipations();
            return Ok(ParticipationMapper.GetParticipations(participations));
        }
        [HttpGet("{participationId}")]
        public IActionResult GetParticipation(Guid participationId)
        {
            Participation participation = _participationService.GetParticipation(participationId);
            return participation == null ? NotFound() : Ok(ParticipationMapper.GetParticipation(participation));
        }
        [HttpGet("profiles")]
        public IActionResult GetParticipationProfiles()
        {
            IEnumerable<Participation> participations = _participationService.GetParticipations();
            return Ok(ParticipationMapper.GetParticipationProfiles(participations));
        }
        [HttpPost]
        public IActionResult InsertParticipation([FromBody] Participation participation)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            _participationService.InsertParticipation(participation);
            return Created("~api/Participation/" + participation.ParticipationId.ToString(), participation);
        }
        [HttpPut]
        public IActionResult UpdateParticipation([FromBody] Participation participation)
        {
            _participationService.UpdateParticipation(participation);
            return Ok();
        }
        [HttpDelete("{participationId}")]
        public IActionResult DeleteParticipation(Guid participationId)
        {
            _participationService.DeleteParticipation(participationId);
            return Ok();
        }
    }
}
