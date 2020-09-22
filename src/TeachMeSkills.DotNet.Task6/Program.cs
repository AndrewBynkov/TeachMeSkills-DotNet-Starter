using System;

namespace TeachMeSkills.DotNet.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            (int operand1, int operand2) = Variable();
            string sign = UserInputMathOrerator();
            (int resultCalculation, int userOperand) = Calculation(operand1, operand2, sign);

            if (sign == "/" && operand2 == 0)
            {
                Console.WriteLine($"Result of calculation with random number ({operand1} and {userOperand}) " +
                    $"and operator ({sign}): --->> {resultCalculation}");
            }
            else
            {
                Console.WriteLine($"Result of calculation with random number ({operand1} and {operand2}) " +
                    $"and operator ({sign}): --->> {resultCalculation}");
            }
        }

        private static (int oper1, int oper2) Variable()
        {
            Random rand = new Random();

            int oper1 = rand.Next(100);
            int oper2 = rand.Next(100);

            return (oper1, oper2);
        }

        private static string UserInputMathOrerator()
        {
            string inpSign = null;
            int count1 = 0;
            string[] operatorsArray = new[] { "+", "-", "/", "*" };

            while (count1 == 0)
            {
                Console.Write("Enter operator +, -, / or * : ");
                inpSign = Console.ReadLine();

                for (int i = 0; i < operatorsArray.Length; i++)
                {
                    if (inpSign == operatorsArray[i])
                    {
                        count1++;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return inpSign;
        }
        private static (int inpOperand, int result) Calculation(int operand1, int operand2, string sign)
        {
            int result = 0;
            bool canParse = false;
            int inpOperand = 0;
            string inpUserNum = null;

            switch (sign)
            {
                case "+":
                    {
                        result = operand1 + operand2;
                    }
                    break;
                case "-":
                    {
                        result = operand1 - operand2;
                    }
                    break;
                case "*":
                    {
                        result = operand1 * operand2;
                    }
                    break;
                case "/":
                    {
                        if (operand2 == 0)
                        {
                            while (inpOperand == 0 || !canParse)
                            {
                                Console.Write($"Exception! Сannot be divided by {operand2}! Enter new number: ");
                                inpUserNum = Console.ReadLine();
                                canParse = int.TryParse(inpUserNum, out int Operand);
                                inpOperand = Operand;
                            }
                            result = operand1 / inpOperand;
                        }

                        else
                        {
                            result = operand1 / operand2;
                        }
                    }
                    break;
            }
            return (result, inpOperand);
        }
    }
}
