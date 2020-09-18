using System;
using System.Dynamic;

namespace TeachMeSkills.DotNet.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "\nмоя строка 1";
            string str2 = "\tмоя строка 2";
            string str3 = "\aмоя строка 3";

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.ReadKey();
        }

    }
}
