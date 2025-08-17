using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Practice_Problems
{
    public class Anagram
    { public bool IsAnagram(string text1, string text2)
        {
            char[] textArray1 = text1.ToLower().ToCharArray();
            Array.Sort(textArray1);
            string sortedText1 = new string(textArray1);

            char[] textArray2 = text2.ToLower().ToCharArray();
            Array.Sort(textArray2);
            string sortedText2 = new string(textArray2);

            Console.WriteLine(sortedText1);
            Console.WriteLine(sortedText2);

            if (sortedText1.Equals(sortedText2, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
