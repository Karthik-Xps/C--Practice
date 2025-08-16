using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Practice_Problems
{
    public class Palindrome
    {
        public string IsPalindrome(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return " Invlaid Input ";
            }
            else
            { 
                char[] to_array = text.ToCharArray();
                Array.Reverse(to_array);
                string reversed_text = new string(to_array);
                if (text.Equals(reversed_text, StringComparison.OrdinalIgnoreCase))
                {
                    return "The text is a palindrome.";
                }
                else
                {
                    return "The text is not a palindrome.";
                }
            }
        }
    }
}
