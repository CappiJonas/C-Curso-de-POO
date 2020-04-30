using System;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] vet = new int[3];

            for (int i = 1; i <= N; i++)
            {
                vet[0] = i;
                vet[1] = i * i;
                vet[2] = i * i * i;

                Console.WriteLine($"{vet[0]} {vet[1]} {vet[2]}");
            }
            Console.ReadKey();
        }
    }
}
