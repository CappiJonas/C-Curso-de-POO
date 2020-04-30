using System;
using System.Globalization;
namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, A, B;
            double divisao;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] S = Console.ReadLine().Split(' ');
                A = int.Parse(S[0]);
                B = int.Parse(S[1]);

                if (B == 0)
                {
                    Console.WriteLine("divisão impossível");
                }
                else
                {
                    divisao = (double) A / B;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
            Console.ReadKey();
        }
    }
}
