using System;

namespace TeachMeSkills.DotNet.Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            (int variable1, int variable2) = Variable();
            (int resultEvenCheck1, int resultEvenCheck2) = EvenCheck1(variable1, variable2);
            (int resultEvenCheck3, int resultEvenCheck4) = EvenCheck2(variable1, variable2);

            Console.WriteLine($"\nNumber {resultEvenCheck1} is even");
            Console.WriteLine($"Number {resultEvenCheck2} is even");
        }

        private static (int resultEvenCheck3, int resultEvenCheck4) EvenCheck2(int variable1, int variable2)
        {
            string num1 = variable1.ToString();
            int indexLastNum = num1.Length;
            int charNum = 0;

            for (int i = 0; i < num1.Length; i++)
            {
                charNum = num1[indexLastNum];
                if (charNum%2 <
            }


            int resultEvenCheck3 = 1;
            int resultEvenCheck4 = 1;
            return (resultEvenCheck3, resultEvenCheck4);
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
                Console.Write("Enter first number: ");
                canParse1 = int.TryParse(Console.ReadLine(), out int value1);
                val1 = value1;
            }

            while (!canParse2)
            {
                Console.Write("Enter second number: ");
                canParse2 = int.TryParse(Console.ReadLine(), out int value2);
                val2 = value2;
            }
            return (val1, val2);
        }
    }
}
