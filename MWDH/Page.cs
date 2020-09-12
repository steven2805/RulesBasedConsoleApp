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
        public void DeleteLine(int linenumber)
        {
            if(linenumber <= Lines.Count && linenumber >= 0)
            {
                Lines.RemoveAt(linenumber);
            }
            else
            {
                //Error handling
            }

        }

        public void swapLines(int firstLine,int secondLine)
        {
            if(!(firstLine > Lines.Count || secondLine > Lines.Count))
            {
                string _tempString = Lines[firstLine].ToString();
                Lines[firstLine] = Lines[secondLine];
                Lines[secondLine] = _tempString;
            }
            else
            {
                //Error handling in here
            }

        }

        internal void editLine(string newString, int lineNumberToChange)
        {
            if(lineNumberToChange <= Lines.Count && lineNumberToChange >= 0)
            {
                Lines[lineNumberToChange] = newString;

            }
            else
            {
                //Error handling in here
            }
        }
    }
}
