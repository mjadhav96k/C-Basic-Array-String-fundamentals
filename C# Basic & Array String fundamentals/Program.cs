using C__Basic___Array_String_fundamentals;
using System;

namespace BasicCsharp
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Select program to run (1 - 15):");
            Console.WriteLine("1. Find the maximum element in a given integer array.");
            Console.WriteLine("2. Calculate the average of all elements in an integer array.");
            Console.WriteLine("3. Check if a given integer is a prime number.");
            int choice = int.Parse(Console.ReadLine());

            switch (choice) 
            {
                case 1:
                    MaximumElement.Run();
                    break;
                case 2:
                    CalculateArrayElementsAvg.Run();
                    break;
                case 3:
                    CheckPrime.Run();
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}