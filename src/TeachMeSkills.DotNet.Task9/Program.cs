using System;

namespace TeachMeSkills.DotNet.Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            (int variable1, int variable2) = Variable();
            (int resultEvenCheck1, int resultEvenCheck2) = EvenCheck1(variable1, variable2);
            (int resultEvenCheck3, int resultEvenCheck4) = EvenCheck2();

            Console.WriteLine("\nFirst checked:");
            Console.WriteLine($"Number {resultEvenCheck1} is even");
            Console.WriteLine($"Number {resultEvenCheck2} is even");

            Console.WriteLine("\nSecond checked:");
            Console.WriteLine($"Number {resultEvenCheck3} is even");
            Console.WriteLine($"Number {resultEvenCheck4} is even");
        }

        private static (int resultEvenCheck3, int resultEvenCheck4) EvenCheck2()
        {
            Console.WriteLine();

            bool canParse1 = false;
            bool canParce2 = false;

            int val1 = 0;
            int val2 = 0;

            int result1 = 0;
            int result2 = 0;

            while (!canParse1)
            {
                Console.Write("Even check2 --->> Enter first number: ");
                canParse1 = int.TryParse(Console.ReadLine(), out int value1);
                val1 = value1;
            }

            while (!canParce2)
            {
                Console.Write("Even check2 --->> Enter second number: ");
                canParce2 = int.TryParse(Console.ReadLine(), out int value2);
                val2 = value2;
            }

            string strVal1 = val1.ToString();
            string strVal2 = val2.ToString();

            for (int i = strVal1.Length - 1; i < strVal1.Length; i++)
            {
                result1 = strVal1[strVal1.Length - 1] % 2;

                if (result1 == 0)
                {
                    Console.WriteLine($"Number {val1} is even! ");
                    break;
                }
                else
                {
                    do
                    {
                        Console.Write($"Number {strVal1} is not even! Try again: ");

                        canParse1 = int.TryParse(Console.ReadLine(), out int value1);
                        strVal1 = value1.ToString();
                        result1 = strVal1[strVal1.Length - 1] % 2;
                    }
                    while (result1 > 0 && canParse1);
                }
            }

            for (int i = strVal2.Length - 1; i < strVal2.Length; i++)
            {
                result2 = strVal2[strVal2.Length - 1] % 2;

                if (result2 == 0)
                {
                    Console.WriteLine($"Number {val2} is even! ");
                    break;
                }
                else
                {
                    do
                    {
                        Console.Write($"Number {strVal2} is not even! Try again: ");
                        canParce2 = int.TryParse(Console.ReadLine(), out int value2);
                        strVal2 = value2.ToString();
                        result2 = strVal2[strVal2.Length - 1] % 2;
                    }
                    while (result2 > 0 && canParce2);
                }
            }
            return (Convert.ToInt32(strVal1), Convert.ToInt32(strVal2));
        }

        private static (int evenResult1, int evenResult2) EvenCheck1(int variable1, int variable2)
        {
            bool canParce = false;
            int result1 = variable1 % 2;
            int result2 = variable2 % 2;

            if (result1 > 0)
            {
                while (result1 > 0 || !canParce)
                {
                    Console.Write($"Number {variable1} in not even, try again: ");
                    canParce = int.TryParse(Console.ReadLine(), out int val1);
                    result1 = val1 % 2;
                    variable1 = val1;
                }
            }

            if (result2 > 0)
            {
                while (result2 > 0 || !canParce)
                {
                    Console.Write($"Number {variable2} in not even, try again: ");
                    canParce = int.TryParse(Console.ReadLine(), out int val2);
                    result2 = val2 % 2;
                    variable2 = val2;
                }
            }
            return (variable1, variable2);
        }

        private static (int val1, int val2) Variable()
        {
            bool canParse1 = false;
            bool canParse2 = false;
            int val1 = 0;
            int val2 = 0;

            while (!canParse1)
            {
                Console.Write("Even check1 --->> Enter first number: ");
                canParse1 = int.TryParse(Console.ReadLine(), out int value1);
                val1 = value1;
            }

            while (!canParse2)
            {
                Console.Write("Even check1 --->> Enter second number: ");
                canParse2 = int.TryParse(Console.ReadLine(), out int value2);
                val2 = value2;
            }

            return (val1, val2);
        }
    }
}
