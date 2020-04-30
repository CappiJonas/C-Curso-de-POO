using System;
using System.Globalization;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double escolha;

            escolha = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (escolha >= 0.0 && escolha <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (escolha > 25.0 && escolha <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (escolha > 50.0 && escolha <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (escolha > 75.0 && escolha <= 100.0)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
            Console.ReadKey();
        }
    }
}
