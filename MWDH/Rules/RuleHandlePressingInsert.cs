using System;
using System.Collections.Generic;
using System.Text;

namespace MWDH
{
    public class RuleHandlePressingInsert : IRules
    {
        private string[] userInputBreakDown;
        public void CheckCondition(string userInput, Page page)
        {
          
           
                if (userInput[0] == 'I' || userInput[0] == 'i')
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

            // Assign the full sentence to the breakdown array
            // Need to capture the full sentence after the 3 lot of white space
            string[] actualValue = userInput.Split(new char[] { ' ' }, 3);
            _breakdown[1] = actualValue[2];

            return _breakdown;

        } 

        public void PerformAction(Page page)
        {
            if (int.TryParse(userInputBreakDown[0], out _))
            {
                page.addLine(userInputBreakDown[1], Convert.ToInt32(this.userInputBreakDown[0]) - 1);
            }
        }
    }
}
