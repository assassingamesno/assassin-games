using assassingames_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Repositories.Interfaces
{
    public interface IRuleRepository
    {
        public Rule GetRule(Guid ruleId);
        public IEnumerable<Rule> GetRules();
        public void InsertRule(Rule rule);
        public void UpdateRule(Rule rule);
        public void DeleteRule(Guid ruleId);
    }
}
