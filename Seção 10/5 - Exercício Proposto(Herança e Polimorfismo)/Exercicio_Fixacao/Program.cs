using Exercicio_Fixacao.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Transactions;

namespace Exercicio_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> Products = new List<Product>();

            Console.Write("Enter the number of the products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                string choose = Console.ReadLine();
                while (choose != "c" && choose != "u" && choose != "i")
                {
                    Console.Write("You need to choose if the product is common(c), used(u) or imported(i). Choose again: ");
                    choose = Console.ReadLine();
                }

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (choose == "c")
                {
                    Product product = new Product(name, price);
                    Products.Add(product);
                }
                else if (choose == "i")
                {
                    Console.Write("Customs Fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Product product = new ImportedProduct(name, price, customsFee);
                    Products.Add(product);
                }
                else
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    Product product = new UsedProduct(name, price, manufactureDate);
                    Products.Add(product);
                }
            }
            Console.WriteLine();

            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in Products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
