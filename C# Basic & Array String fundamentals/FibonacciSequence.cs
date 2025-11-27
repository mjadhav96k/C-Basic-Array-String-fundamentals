using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basic___Array_String_fundamentals
{
    public class FibonacciSequence
    {
        public static void Run()
        {
            Console.WriteLine("Enter N number till which we want fibonacci sequence: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = FiboLogic(num);
            Console.WriteLine("Final Number " + result); 

        }

        public static int FiboLogic(int num)
        {
            int result = 0;

            if (num <= 1)
                return num;

            int[] arr = new int[num];

            arr[0] = 0;
            arr[1] = 1;

            for (int i = 2; i < num; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            foreach (int i in arr)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
            result = arr[num -1];
            return result;
        }
        
    }
}
