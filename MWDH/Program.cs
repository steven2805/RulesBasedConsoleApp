using System;

namespace MWDH
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Make you selection: Example L");
            GetUserInput();
        }


        public static void GetUserInput()
        {
            string _userinput = null;
            Page _newpage = new Page();
            while (_userinput != "Quit")
            {
                _userinput = Console.ReadLine();
                ProcessInput(_userinput, _newpage);
            }


        }

        public static void ProcessInput(String _userInput, Page _newPage)
        {

            IRulesEngine _engine = new DefaultRuleEngine();
            _engine.CheckRules(_userInput, _newPage);

            foreach (string line in _newPage.Lines)
            {
                Console.WriteLine(line);
            }


        }
    }
}
