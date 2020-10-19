using System;

namespace TeachMeSkills.DotNet.Task26
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = 50053;
            int[] myArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            subArray(myArray);
            subArray2(myArray, value);
        }

        private static void subArray(int[] myArray)
        {
            int[] mySubArray = new int[myArray.Length + 1];

            for (int i = 0; i < mySubArray.Length; i++)
            {
                if (i < myArray.Length)
                {
                    mySubArray[i] = myArray[i];
                }
                else
                {
                    mySubArray[i] = 0;
                }
            }

            Console.WriteLine("First task");
            foreach (var item in mySubArray)
            {
                Console.WriteLine($"{item}");
            }
        }

        private static void subArray2(int[] myArray, int value)
        {
            int[] mySubArray = new int[myArray.Length + 1];

            for (int i = 0; i < mySubArray.Length; i++)
            {
                int k = i;
                if (i == 0)
                {
                    mySubArray[i] = value;
                }
                if (i > 0 && i < myArray.Length + 1)
                {
                    mySubArray[i] = myArray[--k];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Second task");
            foreach (var item in mySubArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
