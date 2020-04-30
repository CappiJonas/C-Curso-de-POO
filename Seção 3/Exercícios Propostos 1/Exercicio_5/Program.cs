using System;
using System.Globalization;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1, quant1, cod2, quant2;
            double valor1, valor2, valorTotal;

            string[] peca1 = Console.ReadLine().Split(' ');
            cod1 = int.Parse(peca1[0]);
            quant1 = int.Parse(peca1[1]);
            valor1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

            string[] peca2 = Console.ReadLine().Split(' ');
            cod2 = int.Parse(peca2[0]);
            quant2 = int.Parse(peca2[1]);
            valor2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

            valorTotal = quant1 * valor1 + quant2 * valor2;
            Console.WriteLine($"VALOR A PAGAR: R$ {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.ReadKey();
        }
    }
}
