﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MWDH
{
    class DefaultRuleEngine : IRulesEngine
    {
        private List<IRules> rules = new List<IRules>();
        public DefaultRuleEngine()
        {
            rules.Add(new RuleHandlePressingL());
            rules.Add(new RuleHandlePressingA());
            rules.Add(new RuleHandlePressingInsert());
            rules.Add(new RuleHandlePressingDelete());
            rules.Add(new RuleHandlePressingSwap());
            rules.Add(new RuleHandlePressingEdit());
        }

        public void CheckRules(string userInput, Page page)
        {
            foreach(IRules rule in rules)
            {
                rule.CheckCondition(userInput, page);
               
            }
        }
    }
}
