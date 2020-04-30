using System;
using System.Globalization;
namespace Exercício_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double renda, imposto;

            renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (renda >= 0.0 && renda <= 2000.0)
            {
                Console.WriteLine("Isento");
            }
            else if (renda > 2000.0 && renda <= 3000.0)
            {
                imposto = (renda - 2000.0) * 8.0 / 100.0;
                Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (renda > 3000.0 && renda <= 4500.0)
            {
                imposto = (renda - 3000.0) * 18.0 / 100.0 + 1000.0 * 8.0 / 100.0;
                Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (renda > 4500.0)
            {
                imposto = (renda - 4500.0) * 28.0 / 100.0 + 1500.0 * 18.0 / 100.0 + 1000.0 * 8.0 / 100.0;
                Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            Console.ReadKey();
        }
    }
}
