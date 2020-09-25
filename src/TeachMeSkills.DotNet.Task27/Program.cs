using System;

namespace TeachMeSkills.DotNet.Task27
{
    class Program
    {
        static void Main(string[] args)
        {
            myArray();
        }

        private static void myArray()
        {
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            for (int i = arr.Length; i >= 0; i--)
            {
                Console.WriteLine($"Entments array: {arr[i-1]}");
            }
        }
    }
}
