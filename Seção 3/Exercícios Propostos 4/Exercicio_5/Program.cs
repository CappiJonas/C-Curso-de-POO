using System;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, fatorial;

            fatorial = 1;
            N = int.Parse(Console.ReadLine());

            for (int i = 0; N - i > 1; i++)
            {
                if (N == 0)
                {
                    fatorial = 1;
                }
                else
                {
                    fatorial = fatorial * (N - i);
                }
            }

            Console.WriteLine(fatorial);
            Console.ReadKey();
        }
    }
}
