using System;

namespace TeachMeSkills.DotNet.Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            (int val1, int val2, int val3)=InputUserVal();
            Calculate(val1, val2, val3);
        }

        private static void Calculate(int val1, int val2, int val3)
        {
            float result = (float)(val1 + val2 + val3) / 3;
            Console.WriteLine($"\nResult mean = {result}");
        }

        private static (int val1, int val2, int val3) InputUserVal()
        {
            bool canParce1;

            int value1;
            int value2;
            int value3;
            do
            {
                Console.Write("Enter you first number: ");
                canParce1 = int.TryParse(Console.ReadLine(), out int val);
                value1 = val;
            }
            while (!canParce1);

            do
            {
                Console.Write("Enter you second number: ");
                canParce1 = int.TryParse(Console.ReadLine(), out int val);
                value2 = val;
            }
            while (!canParce1);

            do
            {
                Console.Write("Enter you third number: ");
                canParce1 = int.TryParse(Console.ReadLine(), out int val);
                value3 = val;
            }
            while (!canParce1);

            return (value1, value2, value3);
        }
    }
}
