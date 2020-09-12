using System;
using System.Collections.Generic;
using System.Text;

namespace MWDH
{
    interface IRules
    {
        void CheckCondition(string userInput, Page page);

        void PerformAction(Page page);

    }
}
