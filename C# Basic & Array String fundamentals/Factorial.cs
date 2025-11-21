using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basic___Array_String_fundamentals
{
    public class Factorial
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number to get the factorial of it: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;

            for (int i = num; i >= 1; i--)
            {
                factorial *= i;
            }
            Console.WriteLine($"Factorial of number {num} is {factorial}");
        }
    }
}
