using System;

namespace TeachMeSkills.DotNet.Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            bool canParse = false;
            int num1 = 0;

            while (!canParse)
            {
                Console.Write("Enter int value: ");
                canParse = int.TryParse(Console.ReadLine(), out int inpVal1);
                num1 = inpVal1;
            }

            int[] arr = new int[num1];

            for (int i = 1; i < arr.Length - 1; i++)
            {
                result = i * 2;

                if (result == num1)
                {
                    Console.Write($"Number {num1} is a power of two");
                    break;
                }
            }
            if (result != num1)
            {
                Console.Write($"Number {num1} is not a power of two");
            }

            Console.WriteLine();
        }
    }
}
