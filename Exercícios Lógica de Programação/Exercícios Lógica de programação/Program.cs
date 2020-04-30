using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_Lógica_de_programação
{
    public class Program
    {
        static void Main(string[] args)
        {
            double COD1, COD2, num1, num2, valor1, valor2, valorTotal;

            Console.WriteLine("Código da peça 1: ");
            COD1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de peça 1: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor da peça 1: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Código da peça 2: ");
            COD2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de peça 2: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor da peça 2: ");
            valor2 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            valorTotal = num1 * valor1 + num2 * valor2;
            Console.WriteLine("O valor a ser pago é: " + valorTotal);
            Console.ReadKey();
        }
    }
}
