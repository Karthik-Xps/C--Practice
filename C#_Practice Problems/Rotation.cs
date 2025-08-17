using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Practice_Problems
{
    public class Rotation
    {
        string value = "";
        public bool IsRotation(string text1, string text2)
        {
            value= text1 + text1;
            if (value.Contains(text2))
            {
                return true;
            }
            else
                return false;
        }
    }
}
