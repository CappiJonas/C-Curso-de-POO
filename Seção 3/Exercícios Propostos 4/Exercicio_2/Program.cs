using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, contIn, contOut, numero;

            contIn = 0;
            contOut = 0;
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                numero = int.Parse(Console.ReadLine());

                if (numero >= 10 && numero <= 20)
                {
                    contIn++;
                }
                else
                {
                    contOut++;
                }
            }
            Console.WriteLine($"{contIn} in");
            Console.WriteLine($"{contOut} out");
            Console.ReadKey();
        }
    }
}
