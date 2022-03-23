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
    public class LeadershipController : Controller
    {
        private readonly ILeadershipService _leadershipService;
        public LeadershipController(ILeadershipService leadershipService)
        {
            _leadershipService = leadershipService;
        }
        [HttpGet]
        public IActionResult GetLeaderships()
        {
            IEnumerable<Leadership> leaderships = _leadershipService.GetLeaderships();
            return Ok(LeadershipMapper.GetLeaderships(leaderships));
        }
        [HttpGet("{leadershipId}")]
        public IActionResult GetLeadership(Guid leadershipId)
        {
            Leadership leadership = _leadershipService.GetLeadership(leadershipId);
            return leadership == null ? NotFound() : Ok(LeadershipMapper.GetLeadership(leadership));
        }
        [HttpPost]
        public IActionResult InsertLeadership([FromBody] Leadership leadership)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            _leadershipService.InsertLeadership(leadership);
            return Created("~api/Leadership/" + leadership.LeadershipId.ToString(), leadership);
        }
        [HttpPut]
        public IActionResult UpdateLeadership([FromBody] Leadership leadership)
        {
            _leadershipService.UpdateLeadership(leadership);
            return Ok();
        }
        [HttpDelete("{leadershipId}")]
        public IActionResult DeleteLeadership(Guid leadershipId)
        {
            _leadershipService.DeleteLeadership(leadershipId);
            return Ok();
        }
    }
}
