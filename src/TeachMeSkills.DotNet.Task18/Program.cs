using System;

namespace TeachMeSkills.DotNet.Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputUserVal = UserInpNum();
            OperationWithUserVal(inputUserVal);
        }

        private static void OperationWithUserVal(int inputUserVal)
        {
            if (inputUserVal < 0)
            {
                Console.WriteLine($"\nNumber {inputUserVal} - negative\n");
            }
            else
            {
                Console.WriteLine($"\nNumber {inputUserVal} - positive\n");
            }

            int[] arrayNumOfDivided = new int[] { 2, 5, 3, 6, 9 };

            for (int i = 0; i < arrayNumOfDivided.Length; i++)
            {
                if (inputUserVal % arrayNumOfDivided[i] == 0)
                {
                    Console.WriteLine($"Number {inputUserVal} divided {arrayNumOfDivided[i]} = 0");
                }
                else
                {
                    Console.WriteLine($"Number {inputUserVal} divided {arrayNumOfDivided[i]} != 0");
                }
            }

            if (inputUserVal < 0)
            {
                inputUserVal *= -1;
            }

            int[] arrayNumPrimeNumber = new int[inputUserVal];
            int count = default;

            for (int i = 0; i < arrayNumPrimeNumber.Length; i++)
            {
                int k = i;
                arrayNumPrimeNumber[i] = k + 1;
                if (inputUserVal % arrayNumPrimeNumber[k] != 0)
                {
                    continue;
                }
                else
                {
                    count++;
                }
            }

            if (count <= 2)
            {
                Console.Write("\nNumber is prime\n");
            }
            else
            {
                Console.Write("\nNumber is complex number\n");
            }
        }

        private static int UserInpNum()
        {
            int inpVal;
            bool canParce;
            do
            {
                Console.Write("Enter you number: ");
                canParce = int.TryParse(Console.ReadLine(), out int val1);
                inpVal = val1;
            }
            while (!canParce);

            return inpVal;
        }
    }
}
