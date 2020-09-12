using System;
using System.Collections.Generic;
using System.Text;

namespace MWDH
{
    public class RuleHandlePressingA : IRules
    {
        public void CheckCondition(string userInput, Page page)
        {
            if (userInput.Length == 1)
            {
                if (userInput[0] == 'a' || userInput[0] == 'A')
                {
                    PerformAction(page);
                }
            }
        }

        public void PerformAction(Page page)
        {
            page.addLine("My program is becoming more complicated");
        }
    }
}
