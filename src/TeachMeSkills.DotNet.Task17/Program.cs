using System;

namespace TeachMeSkills.DotNet.Task17
{
    class Program
    {
        private static (decimal exchangeRates, decimal amountOfMoney) UserParametr()
        {
            decimal exchangeRates;
            decimal amountOfMoney;
            bool canParse;

            do
            {
                Console.Write("Please, enter exchange rates: ");
                canParse = decimal.TryParse(Console.ReadLine(), out exchangeRates);
            }
            while (!canParse);

            do
            {
                Console.Write("Please, enter amount of money: ");
                canParse = decimal.TryParse(Console.ReadLine(), out amountOfMoney);
            }
            while (!canParse);

            return (exchangeRates, amountOfMoney);
        }

        private static decimal CalculatedExchanged(decimal exchangeRates, decimal amountOfMoney)
        {
            decimal result = amountOfMoney / exchangeRates;
            return result;
        }

        static void Main(string[] args)
        {
            (decimal exchangeRates, decimal amountOfMoney) = UserParametr();
            decimal result = CalculatedExchanged(exchangeRates, amountOfMoney);
            Console.WriteLine($"\nResult of currency conversion ---> {Math.Round(result, 4)}");
        }
    }
}
