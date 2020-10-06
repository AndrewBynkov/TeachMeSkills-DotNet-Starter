using System;

namespace TeachMeSkills.DotNet.Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            float userSum = UserInputSumPayment();
            BalanceOwed(userSum);
        }

        private static void BalanceOwed(float inpPaymentAmount)
        {
            int count = default;
            float sum = 1000.50F;

            if (inpPaymentAmount == sum || inpPaymentAmount > sum)
            {
                Console.WriteLine($"\nDebt repaid in one payment. \nDebt payer's: {0}\nDebt bank: {sum - inpPaymentAmount}");
            }
            else
            {
                while (inpPaymentAmount < sum)
                {
                    float balance = sum - inpPaymentAmount;
                    if (inpPaymentAmount < sum)
                    {
                        Console.Write($"\nSum of debt - {sum}$. Debt not paid off, reminde - {balance}$\n");
                        inpPaymentAmount += UserInputSumPayment();
                        Console.Write($"\nPayment amount = {inpPaymentAmount}");
                    }
                    if (inpPaymentAmount > sum)
                    {
                        Console.Write($" Debt = {balance} - overpayment");
                    }
                    count++;
                }
            }
            Console.Write($"\nDebt repaid for {count} payments. Amount of payments = {inpPaymentAmount}");
        }

        private static float UserInputSumPayment()
        {
            bool canParse;
            float userValue;

            do
            {
                Console.Write("Enter sum payment: ");
                canParse = float.TryParse(Console.ReadLine(), out float val1);
                userValue = val1;
            }
            while (!canParse);

            return userValue;
        }
    }
}
