using System;

namespace TeachMeSkills.DotNet.Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            int variantDelivery = UserInputVariantDelivery();
            int resVarDelivery = CalculateVariantDelivery(variantDelivery);
            Console.WriteLine($"\nNumber of possible delivery options to the byer - {resVarDelivery}");
        }

        private static int UserInputVariantDelivery()
        {
            int result;
            bool canParse;

            do
            {
                Console.Write("Please, enter quantity delivery: ");
                canParse = int.TryParse(Console.ReadLine(), out result);
            }
            while (!canParse);

            return result;
        }

        private static int CalculateVariantDelivery(int variant)
        {
            int result = 1;

            for (int i = 1; i <= variant; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
