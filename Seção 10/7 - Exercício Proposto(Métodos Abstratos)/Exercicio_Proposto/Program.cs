using Exercicio_Proposto.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_Proposto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payer> Payers = new List<Payer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                string choose = Console.ReadLine();

                while (choose != "i" && choose != "c")
                {
                    Console.Write("You need to choose a valid answer, 'i' for 'individual payer' or 'c' for 'company payer'. " +
                                  "Choose again: ");
                    choose = Console.ReadLine();
                }

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (choose == "i")
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Payers.Add(new IndividualPayer(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of Employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    Payers.Add(new CompanyPayer(name, anualIncome, numberOfEmployees));
                }
            }
            Console.WriteLine();

            Console.WriteLine("TAXES PAID: ");
            foreach (Payer payer in Payers)
            {
                Console.WriteLine($"{payer.Name}: $ {payer.TaxesPaid().ToString("F2", CultureInfo.InvariantCulture)}");
            }
            Console.WriteLine();

            double sum = 0;
            foreach (Payer payer in Payers)
            {
                sum += payer.TaxesPaid();
            }
            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
