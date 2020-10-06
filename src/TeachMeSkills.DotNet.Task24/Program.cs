using System;
using System.Linq;

namespace TeachMeSkills.DotNet.Task24
{
    class Program
    {
        static void Main(string[] args)
        {
            int userLenght = UserInputLenghtArray();
            arrayConstruction(userLenght);
        }

        private static void arrayConstruction(int lenghtArray)
        {
            Random rand = new Random();
            int[] numsArr = new int[lenghtArray];

            for (int i = 0; i < numsArr.Length; i++)
            {
                numsArr[i] = rand.Next(100);
            }

            Console.WriteLine($"\nMax value - {numsArr.Max()}");
            Console.WriteLine($"Min value - {numsArr.Min()}");
            Console.WriteLine($"Sum value - {numsArr.Sum()}");
            Console.WriteLine($"Sum Average - {numsArr.Average()}");
            Console.WriteLine();

            foreach (var item in numsArr)
            {
                if (item % 2 != 0)
                {
                    Console.WriteLine($"Not even number in array - {item}");
                }
                else
                {
                    continue;
                }
            }
        }

        private static int UserInputLenghtArray()
        {
            bool canParse;
            int userValue;
            do
            {
                Console.Write("Enter array lenght: ");
                canParse = int.TryParse(Console.ReadLine(), out int val1);
                userValue = val1;
            }
            while (!canParse);

            return userValue;
        }
    }
}
