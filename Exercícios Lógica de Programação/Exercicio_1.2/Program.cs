using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi, raio, area;
             
            pi = 3.14159;

            Console.WriteLine("Qual o raio do círculo? ");
            raio = double.Parse(Console.ReadLine());
            area = pi * Math.Pow(raio, 2);
            Console.WriteLine("Então a área deste círculo é " + area.ToString("F4"));
                                                      //Limitar casas decimais x.ToString("FY")
                                                      //onde Y é o número de casas decimais
            Console.ReadKey();
        }
    }
}
