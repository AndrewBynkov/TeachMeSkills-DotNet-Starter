using System;

namespace TeachMeSkills.DotNet.Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            (int inputUserStart, int inputUserFinish) = UserInpNum();
            PrimeNumComplexNum(inputUserStart, inputUserFinish);
        }

        private static void PrimeNumComplexNum(int startRange, int finishRange)
        {
            if (startRange < 0 || finishRange < 0)
            {
                startRange *= -1;
                finishRange *= -1;
            }

            int[] numArrInRange = new int[finishRange - startRange + 1];
            for (int i = 0; startRange <= finishRange; i++)
            {
                numArrInRange[i] = startRange;
                startRange++;

                if (numArrInRange[i] % 2 != 0)
                {
                    Console.WriteLine($"Number {numArrInRange[i]} - prime");
                }
                else
                {
                    Console.WriteLine($"Number {numArrInRange[i]} - complex");
                }
            }
        }

        private static (int inpVal1, int inpVal2) UserInpNum()
        {
            int inpVal1;
            int inpVal2;
            bool canParce;

            do
            {
                Console.Write("Enter you number for start range: ");
                canParce = int.TryParse(Console.ReadLine(), out int val1);
                inpVal1 = val1;
            }
            while (!canParce);

            do
            {
                Console.Write("Enter you number number for finish range: ");
                canParce = int.TryParse(Console.ReadLine(), out int val2);
                inpVal2 = val2;
            }
            while (!canParce);

            return (inpVal1, inpVal2);
        }
    }
}
