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
            int choice = int.Parse(Console.ReadLine());

            switch (choice) 
            {
                case 1:
                    MaximumElement.Run();
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