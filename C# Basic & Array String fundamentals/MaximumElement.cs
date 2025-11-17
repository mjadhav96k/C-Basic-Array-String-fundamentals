using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basic___Array_String_fundamentals
{
    public class MaximumElement
    {
        public static void Run()
        {
            Console.WriteLine("Running Program 1...");
            int[] array = new int[]{ 1, 2, 3, 4, 5, 6};
            int max = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            Console.WriteLine($"Maximun element in array is:  {max}");
        }
    }
}
