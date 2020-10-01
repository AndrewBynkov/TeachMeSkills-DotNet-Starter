using System;

namespace TeachMeSkills.DotNet.Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            (int haight, int lenght) = UserParametr();
            DrafRectangle(haight, lenght);
        }

        private static void DrafRectangle(int haight, int lenght)
        {
            char[] star = new char[lenght];

            for (int i = 0; i < star.Length; i++)
            {
                star[i] = '*';
            }

            Console.WriteLine();
            for (int i = 0; i < haight; i++)
            {
                foreach (var item in star)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
        }

        private static (int haight, int lenght) UserParametr()
        {
            int haight;
            int lenght;
            bool canParse;

            do
            {
                Console.Write("Please, enter value haight: ");
                canParse = int.TryParse(Console.ReadLine(), out haight);
            }
            while (!canParse);

            do
            {
                Console.Write("Please, enter value lenght: ");
                canParse = int.TryParse(Console.ReadLine(), out lenght);
            }
            while (!canParse);

            return (haight, lenght);
        }
    }
}
