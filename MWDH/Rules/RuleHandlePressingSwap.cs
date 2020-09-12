using System;
using System.Collections.Generic;
using System.Text;

namespace MWDH
{
    public class RuleHandlePressingSwap : IRules
    {
        private string[] userInputBreakDown;
        public void CheckCondition(string userInput, Page page)
        {            
                if (userInput[0] == 'R' || userInput[0] == 'r')
                {
                    userInputBreakDown = formatInputy(userInput);
                    PerformAction(page);
                }
           
        }

        public string[] formatInputy(string userInput)
        {
            string[] _breakdown = new string[2];

            // Assign the position int to the breakdown array
            string[] _splitwords = userInput.Split();
            _breakdown[0] = _splitwords[1];
            _breakdown[1] = _splitwords[2];



            return _breakdown;

        } 

        public void PerformAction(Page page)
        {
            if (int.TryParse(userInputBreakDown[0], out _) && int.TryParse(userInputBreakDown[1], out _))
            {
                page.swapLines(Convert.ToInt32(this.userInputBreakDown[0]) - 1, Convert.ToInt32(this.userInputBreakDown[1]) - 1);
            }
        }
    }
}
