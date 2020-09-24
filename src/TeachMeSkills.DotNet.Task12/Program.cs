using System;

namespace TeachMeSkills.DotNet.Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 4;

            int res = a | b;
            int res2 = b & a;
            Console.WriteLine(res);
            Console.WriteLine(res2);
        }
    }
}
