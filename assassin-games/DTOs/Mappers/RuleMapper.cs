using assassingames_backend.Models;
using assassingames_backend.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.DTOs.Mappers
{
    public static class RuleMapper
    {
        public static IEnumerable<RuleDTO> GetRules(IEnumerable<Rule> rules)
        {
            IEnumerable<RuleDTO> ruleDTOs = rules.Select(rule =>
            new RuleDTO()
            {
                RuleId = rule.RuleId,
                Description = rule.Description,
                Phase = rule.Phase,
                Added = rule.Added,
                SeasonId = rule.SeasonId
            });
            return ruleDTOs;
        }
        public static RuleDTO GetRule(Rule rule)
        {
            RuleDTO ruleDTO = new()
            {
                RuleId = rule.RuleId,
                Description = rule.Description,
                Phase = rule.Phase,
                Added = rule.Added,
                SeasonId = rule.SeasonId
            };
            return ruleDTO;
        }
    }
}
