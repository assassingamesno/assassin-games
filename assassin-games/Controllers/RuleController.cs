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
    public class RuleController: Controller
    {
        private readonly IRuleService _ruleService;
        public RuleController(IRuleService ruleService)
        {
            _ruleService = ruleService;
        }
        [HttpGet]
        public IActionResult GetRules()
        {
            IEnumerable<Rule> rules =_ruleService.GetRules();
            return Ok(RuleMapper.GetRules(rules));
        }
        [HttpGet("{ruleId}")]
        public IActionResult GetRule(Guid ruleId)
        {
            Rule rule = _ruleService.GetRule(ruleId);
            return rule == null ? NotFound() :  Ok(RuleMapper.GetRule(rule));
        }
        [HttpPost]
        public IActionResult InsertRule([FromBody] Rule rule)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            _ruleService.InsertRule(rule);
            return Created("~api/Rule/" + rule.RuleId.ToString(), rule);
        }
        [HttpPut]
        public IActionResult UpdateRule([FromBody] Rule rule)
        {
            _ruleService.UpdateRule(rule);
            return Ok();
        }
        [HttpDelete("{ruleId}")]
        public IActionResult DeleteRule(Guid ruleId)
        {
            _ruleService.DeleteRule(ruleId);
            return Ok();
        }
    }
}
