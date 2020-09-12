using System;
using System.Collections.Generic;
using System.Text;

namespace MWDH
{
    interface IRulesEngine
    {
        void CheckRules(string userInput, Page page);
    }
}
