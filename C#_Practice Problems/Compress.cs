using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Practice_Problems
{
    public class Compress
    {
        public string CompressString(string text)
        {
            char[] textarray = text.ToCharArray();
            Array.Sort(textarray);
            string value= string.Empty;
            int count = 1;
            for (int i=0; i<textarray.Length-2;i++)
            {
                
                if (textarray[i] == textarray[i + 1])
                {
                    count++;
                }
                else
                {
                   value =value + textarray[i]+count.ToString();
                    count = 1;
                }
            }
            return value;
        }
    }
}
