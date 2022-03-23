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
    public class HuntController : Controller
    {
        private readonly IHuntService _huntService;
        public HuntController(IHuntService huntService)
        {
            _huntService = huntService;
        }
        [HttpGet]
        public IActionResult GetHunts()
        {
            IEnumerable<Hunt> hunts = _huntService.GetHunts();
            return Ok(HuntMapper.GetHunts(hunts));
        }
        [HttpGet("{huntId}")]
        public IActionResult GetHunt(Guid huntId)
        {
            Hunt hunt = _huntService.GetHunt(huntId);
            return hunt == null ? NotFound() : Ok(HuntMapper.GetHunt(hunt));
        }
        [HttpPost]
        public IActionResult InsertHunt([FromBody] Hunt hunt)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            _huntService.InsertHunt(hunt);
            return Created("~api/Hunt/" + hunt.HuntId.ToString(), hunt);
        }
        [HttpPut]
        public IActionResult UpdateHunt([FromBody] Hunt hunt)
        {
            _huntService.UpdateHunt(hunt);
            return Ok();
        }
        [HttpDelete("{huntId}")]
        public IActionResult DeleteHunt(Guid huntId)
        {
            _huntService.DeleteHunt(huntId);
            return Ok();
        }
    }
}
