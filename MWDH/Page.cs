using System;
using System.Collections.Generic;
using System.Text;


namespace MWDH
{
    public class Page 
    {
        public List<string> Lines;
        public int nextFreeLine;

        public Page()
        {
            this.Lines = new List<string>();
            this.nextFreeLine = 0;
        }

        public void addLine(string lineToAdd)
        {
            Lines.Add(lineToAdd);
            nextFreeLine++;
        }
    }
}
