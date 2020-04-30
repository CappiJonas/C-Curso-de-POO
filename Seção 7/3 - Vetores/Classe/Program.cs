using System;
using System.Globalization;

namespace Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Product[] vet = new Product[N];

            for (int i = 0; i < N; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //vet[i] = new Product ();
                //vet[i].Name = name;
                //vet[i].Price = price;
                vet[i] = new Product { Name = name, Price = price };
            }

            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma += vet[i].Price;
            }

            double media = soma / N;
            Console.WriteLine($"AVERAGE PRICE = {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
