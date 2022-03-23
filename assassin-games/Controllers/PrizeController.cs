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
    public class PrizeController : Controller
    {
        private readonly IPrizeService _prizeService;
        public PrizeController(IPrizeService prizeService)
        {
            _prizeService = prizeService;
        }
        [HttpGet]
        public IActionResult GetPrizes()
        {
            IEnumerable<Prize> prizes = _prizeService.GetPrizes();
            return Ok(PrizeMapper.GetPrizes(prizes));
        }
        [HttpGet("{prizeId}")]
        public IActionResult GetPrize(Guid prizeId)
        {
            Prize prize = _prizeService.GetPrize(prizeId);
            return prize == null ? NotFound() : Ok(PrizeMapper.GetPrize(prize));
        }
        [HttpPost]
        public IActionResult InsertPrize([FromBody] Prize prize)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            _prizeService.InsertPrize(prize);
            return Created("~api/Prize/" + prize.PrizeId.ToString(), prize);
        }
        [HttpPut]
        public IActionResult UpdatePrize([FromBody] Prize prize)
        {
            _prizeService.UpdatePrize(prize);
            return Ok();
        }
        [HttpDelete("{prizeId}")]
        public IActionResult DeletePrize(Guid prizeId)
        {
            _prizeService.DeletePrize(prizeId);
            return Ok();
        }
    }
}
