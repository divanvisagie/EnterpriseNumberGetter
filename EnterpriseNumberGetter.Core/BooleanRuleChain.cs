using System.Collections.Generic;
using System.Linq;
using EnterpriseNumberGetter.Core.Rules;

namespace EnterpriseNumberGetter.Core
{
    public class BooleanRuleChain 
    {
        List<IRule<bool>> rules = new List<IRule<bool>>();
        public void Add(IRule<bool> rule)
        {
            rules.Add(rule);
        }       

        //Returns true if all are true
        public bool EvaluateAnd() 
        {
            return rules.All(rule => rule.Evaluate());
        }

        //Returns true if any are true
        public bool EvaluateOr()
        {
            return rules.Any(rule => rule.Evaluate());
        }
    }
}
