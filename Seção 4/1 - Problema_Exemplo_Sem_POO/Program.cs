using System;
using System.Globalization;

namespace Problema_Exemplo_Sem_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, areaX, xP, yA, yB, yC, areaY, yP;

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            xP = (xA + xB + xC) / 2.0;
            areaX = Math.Sqrt(xP * (xP - xA) * (xP - xB) * (xP - xC));

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            yP = (yA + yB + yC) / 2.0;
            areaY = Math.Sqrt(yP * (yP - yA) * (yP - yB) * (yP - yC));

            Console.WriteLine($"Área de X = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
            Console.ReadKey();
        }
    }
}
