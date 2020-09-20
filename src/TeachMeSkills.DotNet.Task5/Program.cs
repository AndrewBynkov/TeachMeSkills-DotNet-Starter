using System;

namespace TeachMeSkills.DotNet.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool canParce1 = false;
            bool canParce2 = false;
            int value1 = 0;
            int value2 = 0;
            int result = 0;

            while (!canParce1)
            {
                Console.Write("Enter first int number: ");
                canParce1 = int.TryParse(Console.ReadLine(), out int val1);
                value1 = val1;

                while (!canParce2)
                {
                    Console.Write("Enter second int number: ");
                    canParce2 = int.TryParse(Console.ReadLine(), out int val2);
                    value2 = val2;
                }
            }
            result = value1 + value2;
            Console.WriteLine($"\nResult of sum: {result}");

            result = value1 - value2;
            Console.WriteLine($"Result of minus: {result}");

            result = value1 * value2;
            Console.WriteLine($"Result of multiplication: {result}");

            result = value1 / value2;
            Console.WriteLine($"Result of division: {result}");
        }
    }
}
