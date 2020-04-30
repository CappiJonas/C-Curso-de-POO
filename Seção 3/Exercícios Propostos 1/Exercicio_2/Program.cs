using System;
using System.Globalization;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, pi, areaCirculo;

            pi = 3.14159;
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            areaCirculo = pi * Math.Pow(raio, 2.0);
            Console.WriteLine($"A={areaCirculo.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.ReadKey();
        }
    }
}
