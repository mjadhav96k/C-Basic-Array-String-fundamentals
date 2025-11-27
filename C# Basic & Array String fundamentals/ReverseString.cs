using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basic___Array_String_fundamentals
{
    public class ReverseString
    {
        public static void Run()
        {
            string str = "Mayuresh";
            string newString = null;

            for(int i= str.Length - 1; i>=0; i--)
            {
                newString = newString + str[i]; 
            }
            Console.WriteLine(newString);

        }
    }
}
