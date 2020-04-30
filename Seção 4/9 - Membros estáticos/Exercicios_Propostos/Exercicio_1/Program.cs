using System;
using System.Globalization;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dolar? ");
            ConversorDeMoeda.cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            ConversorDeMoeda.valorDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Valor a ser pago em reais =" +
                              $" {ConversorDeMoeda.ValorPagoEmReias().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
