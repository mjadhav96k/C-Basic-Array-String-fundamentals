using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basic___Array_String_fundamentals
{
    public class CheckPrime
    {
        public static void Run()
        {
            Console.WriteLine("enter number to check prime: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(IsPrime(num))
            {
                Console.WriteLine($"{num} It is prime");
            }
            else
            {
                Console.WriteLine($"{num} It is not prime");
            }
        }

        public static bool IsPrime(int num)
        {
            if (num <= 1)
                return false;
            if(num == 2)
            {
                return true;
            }
            if(num / 2 == 0)
            {
                return false;
            }
            int squareRoot = Convert.ToInt32(Math.Ceiling(Math.Sqrt(num)));
            for (int i = 3; i <= squareRoot; i++)
            {
                if(num / i == 0)
                    return false;
            }
            return true;
        }
    }
}
