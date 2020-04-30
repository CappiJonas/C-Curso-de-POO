using System;
using System.Globalization;

namespace Exercicios_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r;

            r = new Retangulo();
            Console.WriteLine("Entre com a largura e alturo do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Área = {r.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Perímetro = {r.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal = {r.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}"); 
        }
    }
}
