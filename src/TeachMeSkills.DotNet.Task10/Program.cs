using System;

namespace TeachMeSkills.DotNet.Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            (decimal expEmployee, decimal salEmployer, string nameEmployee) = UserInpData();
            Console.WriteLine();
            (decimal roundetSal, decimal roundetPre) = CalculationOfPremium(salEmployer, expEmployee, nameEmployee);

            Console.WriteLine($"Employer {nameEmployee} have a {expEmployee} years exprience, " +
                $"and his salry with premium = {roundetSal} and sum premium = {roundetPre}");
        }

        private static (decimal roundetSalaryWithPrem, decimal roundetPremiumEmplouer) CalculationOfPremium(decimal salEmployer, decimal expEmployee, string nameEmployee)
        {
            decimal roundetSalaryWithPrem = 0M;
            decimal roundetPremiumEmplouer = 0M;
            decimal[] arrRangeExp = new decimal[100];

            for (int i = 0; i < arrRangeExp.Length; i++)
            {
                arrRangeExp[i] = i;

                while (expEmployee > 99 || expEmployee < 0)
                {
                    Console.Write($"WOW! Such work experience cannot be! Try enter experience of employee again: ");
                    expEmployee = Convert.ToInt32(Console.ReadLine());
                }

                if (arrRangeExp[i] == expEmployee)
                {
                    decimal premiumEmployer;
                    decimal salaryWithPrem;
                    if (expEmployee >= 0 && expEmployee <= 4)
                    {
                        premiumEmployer = salEmployer * 0.1M;
                        salaryWithPrem = salEmployer + premiumEmployer;
                        roundetSalaryWithPrem = Math.Round(salaryWithPrem, 2);
                        roundetPremiumEmplouer = Math.Round(premiumEmployer, 2);
                    }

                    if (expEmployee >= 5 && expEmployee <= 9)
                    {
                        premiumEmployer = salEmployer * 0.15M;
                        salaryWithPrem = salEmployer + premiumEmployer;
                        roundetSalaryWithPrem = Math.Round(salaryWithPrem, 2);
                        roundetPremiumEmplouer = Math.Round(premiumEmployer, 2);
                    }

                    if (expEmployee >= 10 && expEmployee <= 14)
                    {
                        premiumEmployer = salEmployer * 0.25M;
                        salaryWithPrem = salEmployer + premiumEmployer;
                        roundetSalaryWithPrem = Math.Round(salaryWithPrem, 2);
                        roundetPremiumEmplouer = Math.Round(premiumEmployer, 2);
                    }

                    if (expEmployee >= 15 && expEmployee <= 24)
                    {
                        premiumEmployer = salEmployer * 0.45M;
                        salaryWithPrem = salEmployer + premiumEmployer;
                        roundetSalaryWithPrem = Math.Round(salaryWithPrem, 2);
                        roundetPremiumEmplouer = Math.Round(premiumEmployer, 2);
                    }

                    if (expEmployee >= 25)
                    {
                        premiumEmployer = salEmployer * 0.5M;
                        salaryWithPrem = salEmployer + premiumEmployer;
                        roundetSalaryWithPrem = Math.Round(salaryWithPrem, 2);
                        roundetPremiumEmplouer = Math.Round(premiumEmployer, 2);
                    }
                }
            }
            return (roundetSalaryWithPrem, roundetPremiumEmplouer);
        }

        private static (decimal expEmployee, decimal salaryEmployer, string nameEmployee) UserInpData()
        {
            string nameEmployer;

            Console.Write("Enter name of employer: ");
            nameEmployer = Console.ReadLine();

            bool canParse1;
            decimal expEmployoer;
            do
            {
                Console.Write("Enter expearence of employer: ");
                canParse1 = decimal.TryParse(Console.ReadLine(), out decimal inpExp1);
                expEmployoer = inpExp1;
            }
            while (!canParse1);

            bool canParse2;
            decimal salaryEmployer;
            do
            {
                Console.Write("Enter total salary of employer: ");
                canParse2 = decimal.TryParse(Console.ReadLine(), out decimal inpExp2);
                salaryEmployer = inpExp2;
            }
            while (!canParse2);

            return (expEmployoer, salaryEmployer, nameEmployer);
        }
    }
}
