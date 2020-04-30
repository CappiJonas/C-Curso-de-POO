using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N, soma;

            M = int.Parse(Console.ReadLine());
            N = int.Parse(Console.ReadLine());
            soma = M + N;
            Console.WriteLine($"SOMA = {soma}");
            Console.ReadKey();
        }
    }
}
