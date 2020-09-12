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

        public void addLine(string stringToAdd, int? insertAtLine = null)
        {
            if(insertAtLine == null)
            {
                Lines.Add(stringToAdd);
                nextFreeLine++;
            }
            else
            {
                //Stop out of bounds from happening

                while (nextFreeLine < insertAtLine)
                {
                    Lines.Insert(nextFreeLine, "");
                    nextFreeLine++;
                }

                Lines.Insert((int)insertAtLine, stringToAdd);
                this.nextFreeLine = (int)insertAtLine + 1;
            }


        }
    }
}
