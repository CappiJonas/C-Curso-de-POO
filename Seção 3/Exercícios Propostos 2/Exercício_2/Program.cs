using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
