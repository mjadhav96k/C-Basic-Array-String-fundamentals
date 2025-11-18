using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basic___Array_String_fundamentals
{
    internal class CalculateArrayElementsAvg
    {
        public static void Run()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            float avg = 0.0f;
            int count = arr.Length;

            foreach (int i in arr)
            {
                avg += i;
            }
            avg = avg / arr.Length;
            Console.WriteLine("Avergae of all elements present in array is : " + avg);
        }
    }
}
