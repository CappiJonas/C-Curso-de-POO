using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, delta;
            

            Console.WriteLine("Forma da equação de segundo grau: ax² + bx + c = 0");

            Console.WriteLine();

            Console.WriteLine("Qual o valor de a? ");
            a = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Impossível Calcular");
            }
            else
            {
                Console.WriteLine("Qual o valor de b? ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Qual o valor de c? ");
                c = double.Parse(Console.ReadLine());
                Console.ReadKey();

                Console.WriteLine();

                delta = Math.Pow(b, 2.0) - 4.0 * a * c;
                if (delta < 0.0)
                {
                    Console.WriteLine("Impossível Calcular, pois delta é menor que 0");
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                    Console.WriteLine("As raízes das equações são " + x1 + " e " + x2);
                }
            }
            Console.ReadKey();
        }
    }
}
