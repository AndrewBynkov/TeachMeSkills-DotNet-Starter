using System;

namespace TeachMeSkills.DotNet.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.141592653;

            double vCylinder;
            double sCylinder;

            double rCylinder = 4.4;
            double hCylinder = 3;

            vCylinder = (pi * (rCylinder * rCylinder)) * hCylinder;
            sCylinder = 2 * pi * rCylinder * (rCylinder + hCylinder);

            Console.WriteLine($"V cylinder = {vCylinder}, S cylinder = {sCylinder}");
        }
    }
}
