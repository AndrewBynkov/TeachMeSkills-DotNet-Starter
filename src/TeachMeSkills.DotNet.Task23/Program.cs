using System;

namespace TeachMeSkills.DotNet.Task23
{
    class Program
    {
        static void Main(string[] args)
        {
            int userVal = InputUserVal();
            int result = Factorial(userVal);
            Console.WriteLine($"Count variant of delifery: {result}");
        }

        private static int InputUserVal()
        {
            bool canParse;
            int parseResult;
            do
            {
                Console.Write("Enter count of delivery: ");
                canParse = int.TryParse(Console.ReadLine(), out int val1);
                parseResult = val1;
            }
            while (!canParse);

            return parseResult;
        }

        static int Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
    }
}
