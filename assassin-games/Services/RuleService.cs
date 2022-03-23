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
    public class RuleService : IRuleService
    {
        private readonly IRuleRepository _ruleRepository;
        public RuleService(IRuleRepository ruleRepository)
        {
            _ruleRepository = ruleRepository;
        }
        public void DeleteRule(Guid ruleId)
        {
            _ruleRepository.DeleteRule(ruleId);
        }

        public Rule GetRule(Guid ruleId)
        {
            return _ruleRepository.GetRule(ruleId);
        }

        public IEnumerable<Rule> GetRules()
        {
            return _ruleRepository.GetRules();
        }

        public void InsertRule(Rule rule)
        {
            _ruleRepository.InsertRule(rule);
        }

        public void UpdateRule(Rule rule)
        {
            _ruleRepository.UpdateRule(rule);
        }
    }
}
