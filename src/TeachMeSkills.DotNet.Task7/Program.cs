using System;

namespace TeachMeSkills.DotNet.Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int inpValue = InpNumUser();
            RangeCheck(inpValue);
        }

        private static int InpNumUser()
        {
            bool canParse = false;
            int inpVal = 0;
            do
            {
                Console.Write("Enter you value (int only): ");
                canParse = int.TryParse(Console.ReadLine(), out int Val);
                inpVal = Val;
            }
            while (!canParse);

            return inpVal;
        }

        private static void RangeCheck(int userValue)
        {
            int[] arr = new int[101];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;

                while (userValue > 100 || userValue < 0)
                {
                    Console.Write($"Number - {userValue} ouside in range[0 - 100]! Try enter number again: ");
                    userValue = Convert.ToInt32(Console.ReadLine());
                }

                if (arr[i] == userValue)
                {
                    if (userValue >= 0 && userValue <= 14)
                    {
                        Console.WriteLine($"It is a number {userValue} in a range [0-14]");
                    }
                    if (userValue >= 15 && userValue <= 35)
                    {
                        Console.WriteLine($"It is a number {userValue} in a range [15-35]");
                    }
                    if (userValue >= 35 && userValue <= 49)
                    {
                        Console.WriteLine($"It is a number {userValue} in a range [36-50]");
                    }
                    if (userValue == 50)
                    {
                        Console.WriteLine($"It is a number {userValue} in a range [36-50] and [50-100]");
                    }
                    if (userValue >= 51 && userValue <= 100)
                    {
                        Console.WriteLine($"It is a number {userValue} in a range [50-100]");
                    }
                }
            }
        }
    }
}
