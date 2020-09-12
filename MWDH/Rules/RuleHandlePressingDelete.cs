using System;
using System.Collections.Generic;
using System.Text;

namespace MWDH
{
    public class RuleHandlePressingDelete : IRules
    {
        string deleteLineNo;
        public void CheckCondition(string userInput, Page page)
        {
          
           
                if (userInput[0] == 'D' || userInput[0] == 'd')
                {
                    deleteLineNo = formatInputy(userInput);
                    PerformAction(page);
                }
           
        }

        public string formatInputy(string userInput)
        {
            
            // Assign the position int to the breakdown array
            string[] _splitwords = userInput.Split();
            string _linetodelete = _splitwords[1].ToString();

            return _linetodelete;

        } 

        public void PerformAction(Page page)
        {
            if (int.TryParse(deleteLineNo, out _))
            {
                page.DeleteLine(Convert.ToInt32(deleteLineNo) - 1) ;
            }
        }
    }
}
