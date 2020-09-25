using System;

namespace TeachMeSkills.DotNet.Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 19;

            int sumNum = NumInRange(a, b);
            NumEven(a, b);
            Console.WriteLine($"\nSum all number in range [{a}-{b}]: {sumNum}");
        }

        private static void NumEven(int a, int b)
        {
            for (int i = a; a < b; i++)
            {
                if (i % 2 > 0)
                {
                    Console.WriteLine($"Don't even nums in range [{a}-{b}]: {i}");
                }

                if (i > b - 1)
                {
                    break;
                }
            }
        }

        private static int NumInRange(int a, int b)
        {
            int res = 0;
            for (int i = a; a < b; i++)
            {
                res += i;
                if (i > b-1)
                {
                    break;
                }
            }
            return(res);
        }
    }
}
