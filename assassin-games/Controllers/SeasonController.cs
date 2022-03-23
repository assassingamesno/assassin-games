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
    public class SeasonController: Controller
    {
        private readonly ISeasonService _seasonService;
        public SeasonController(ISeasonService seasonService)
        {
            _seasonService = seasonService;
        }
        [HttpGet]
        public IActionResult GetSeasons()
        {
            IEnumerable<Season> seasons = _seasonService.GetSeasons();
            return Ok(SeasonMapper.GetSeasons(seasons));
        }
        [HttpGet("{seasonId}")]
        public IActionResult GetSeason(Guid seasonId)
        {
            Season season = _seasonService.GetSeason(seasonId);
            return season == null ? NotFound() : Ok(SeasonMapper.GetSeason(season));
        }
        [HttpPost]
        public IActionResult InsertSeason([FromBody] Season season)
        {
            if (!ModelState.IsValid ||
                DateTime.Compare(season.RegistrationStart,season.RegistrationEnd) > 0 ||
                DateTime.Compare(season.RegistrationEnd, season.SeasonStart) > 0)
                return BadRequest();
            _seasonService.InsertSeason(season);
            return Created("~api/Season/"+season.SeasonId.ToString(), season);
        }
        [HttpPut]
        public IActionResult UpdateSeason([FromBody] Season season)
        {
            _seasonService.UpdateSeason(season);
            return Ok();
        }
        [HttpDelete("{seasonId}")]
        public IActionResult DeleteSeason(Guid seasonId)
        {
            _seasonService.DeleteSeason(seasonId);
            return Ok();
        }
    }
}
