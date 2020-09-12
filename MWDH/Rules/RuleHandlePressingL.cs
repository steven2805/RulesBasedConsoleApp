using System;
using System.Collections.Generic;
using System.Text;

namespace MWDH
{
    public class RuleHandlePressingL : IRules
    {
        public void CheckCondition(string userInput, Page page)
        {
            if (userInput.Length == 1)
            {
                if (userInput[0] == 'l' || userInput[0] == 'L')
                {
                    PerformAction(page);
                }
            }
        }

        public void PerformAction(Page page)
        {
            page.addLine("Welcome to the timewarp of programs");
            page.addLine("Applications like this were used in the 1980's");
            page.addLine("I can't wait for the USer Interface to be invented");
            page.addLine("Then I can do much more complicated things");
        }
    }
}
