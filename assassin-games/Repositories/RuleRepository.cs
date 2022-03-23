using assassingames_backend.DbContexts;
using assassingames_backend.Models;
using assassingames_backend.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Repositories
{
    public class RuleRepository : IRuleRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public RuleRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public void DeleteRule(Guid ruleId)
        {
            Rule rule = _applicationDbContext.Rules.Find(ruleId);
            _applicationDbContext.Rules.Remove(rule);
            _applicationDbContext.SaveChanges();
        }

        public Rule GetRule(Guid ruleId)
        {
            return _applicationDbContext.Rules.Find(ruleId);
        }

        public IEnumerable<Rule> GetRules()
        {
            return _applicationDbContext.Rules;
        }

        public void InsertRule(Rule rule)
        {
            _applicationDbContext.Rules.Add(rule);
            _applicationDbContext.SaveChanges();
        }

        public void UpdateRule(Rule rule)
        {
            _applicationDbContext.Rules.Update(rule);
            _applicationDbContext.SaveChanges();
        }
    }
}
