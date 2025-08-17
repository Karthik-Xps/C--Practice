using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Practice_Problems
{
    public class NonRepeatingChar
    {
        public char NonRepchar(string text)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();
            foreach (char c in text)
            {
                if(result.ContainsKey(c))
                {
                    result[c]++;
                }
                else
                {
                    result[c] = 1;
                }
            }
            foreach(char c in text)
            {
                if (result[c]==1)
                {
                    return c;
                }
            }
            return '\0'; // Return null character if no non-repeating character is found
        }
    }
}
