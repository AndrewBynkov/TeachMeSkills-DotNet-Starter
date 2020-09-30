using System;

namespace TeachMeSkills.DotNet.Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            (int val1, int val2, int val3) = InputUserVal();
            Calculate(val1, val2, val3);
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

        private static void Calculate(int val1, int val2, int val3)
        {
            float res1 = (float)val1 / 5;
            float res2 = (float)val2 / 5;
            float res3 = (float)val3 / 5;

            Console.WriteLine($" {val1} / 5 = {res1}");
            Console.WriteLine($" {val2} / 5 = {res2}");
            Console.WriteLine($" {val3} / 5 = {res3}");
        }
    }
}
