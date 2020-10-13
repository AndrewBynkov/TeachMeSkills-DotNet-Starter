using System;

namespace TeachMeSkills.DotNet.Task25
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            bool canParse;
            do
            {
                Console.Write("Enter count element array: ");
                canParse = int.TryParse(Console.ReadLine(), out int val1);
                count = val1;
            }
            while (!canParse);

            int Index;
            do
            {
                Console.Write("Enter index start array: ");
                canParse = int.TryParse(Console.ReadLine(), out int val1);
                Index = val1;
            }
            while (!canParse);

            int[] myArray = MyArray();
            int[] reversArray = ArrayReverse(myArray);
            SubArray(reversArray, Index, count);
        }

        private static void SubArray(int[] reversArray, int index, int count)
        {
            int newLenght = count - index;
            int Lenght;

            if (reversArray.Length < newLenght)
            {
                Lenght = reversArray.Length + newLenght;
            }
            else
            {
                Lenght = reversArray.Length;
            }

            int[] subArray = new int[Lenght];

            for (int i = index; i < count; i++)
            {
                if (i < reversArray.Length)
                {
                    subArray[i] = reversArray[i];
                }
                else
                {
                    subArray[i] = 1;
                }
            }

            Console.WriteLine();
            foreach (var item in subArray)
            {
                if (item.Equals(0))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"Element of subarray: {item}");
                }
            }
        }

        private static int[] ArrayReverse(int[] myArray)
        {
            int myarrayReverse = myArray.Length;
            int[] arrayReverse = new int[myarrayReverse];

            for (int i = myArray.Length - 1; i > 0; i--)
            {
                for (int k = 0; k < arrayReverse.Length; k++)
                {
                    arrayReverse[k] = myArray[i];
                    i--;
                }
            }
            return arrayReverse;
        }

        private static int[] MyArray()
        {
            int[] myArray = new int[] { 1, 4, 5, 3, 5, 7, 8 };
            return myArray;
        }
    }
}
