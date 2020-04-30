using System;
using System.Globalization;

namespace Expressao_Condicional_Ternaria
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sintaxe ("condição") ? "valor se verdareiro" : "valor se falso"

            // ("2 > 4") ? "50" : "80" -----------> Imprimir 80

            // ("10 != 3") ? "Maria" : "Alex" -----------> Imprimir "Maria"

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            //if (preco < 20.0)
            //{
            //    desconto = preco * 0.1;
            //}
            //else
            //{
            //    desconto = preco * 0.05;
            //}
            Console.WriteLine(desconto.ToString(CultureInfo.InvariantCulture));
        }
    }
}
