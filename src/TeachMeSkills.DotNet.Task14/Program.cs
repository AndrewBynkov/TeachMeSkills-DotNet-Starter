using System;

namespace TeachMeSkills.DotNet.Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            rectangle();
            Console.Write("\n\n\n");
            RightTriangle();
            Console.Write("\n\n\n");
            EquilateralTriangle();
            Console.Write("\n\n\n");
            Rhombus();
        }
        private static void rectangle()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.Write("* ");
            }
            for (int i = 1; i < 5; i++)
            {
                Console.Write("\n*               *");
            }
            for (int i = 1; i < 5; i++)
            {
                Console.Write("");
            }
            Console.Write("\n");
            for (int i = 1; i < 10; i++)
            {
                Console.Write("* ");
            }
        }

        private static void RightTriangle()
        {
            Console.Write("*");
            Console.Write("\n* *");
            Console.Write("\n*    *");
            Console.Write("\n*        *");
            Console.Write("\n*           *");
            Console.Write("\n* * * * * * * *");
        }

        private static void EquilateralTriangle()
        {
            Console.Write("     *");
            Console.Write("\n   *   *");
            Console.Write("\n *       *");
            Console.Write("\n* * * * * *");
        }

        private static void Rhombus()
        {
            Console.Write("     *");
            Console.Write("\n   *   *");
            Console.Write("\n *       *");
            Console.Write("\n*         *");
            Console.Write("\n *       *");
            Console.Write("\n   *   *");
            Console.Write("\n     *");
        }
    }
}