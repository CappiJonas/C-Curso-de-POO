using System;
using System.Globalization;
namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;

            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            //Triângulo
            double areaTriangulo;
            areaTriangulo = A * C / 2;
            Console.WriteLine($"TRIANGULO: {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}");

            //Círculo
            double areaCirculo, pi;
            pi = 3.14159;
            areaCirculo = pi * Math.Pow(C, 2.0);
            Console.WriteLine($"CIRCULO: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");

            //Trapézio
            double areaTrapezio;
            areaTrapezio = (A + B) * C / 2;
            Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");

            //Quadrado
            double areaQuadrado;
            areaQuadrado = Math.Pow(B, 2.0);
            Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");

            //Retângulo
            double areaRetangulo;
            areaRetangulo = A * B;
            Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.ReadKey();
        }
    }
}
