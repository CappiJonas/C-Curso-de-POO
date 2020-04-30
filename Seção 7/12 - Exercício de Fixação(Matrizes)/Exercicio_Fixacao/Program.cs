using System;

namespace Exercicio_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;

            string[] s = Console.ReadLine().Split(' ');
            M = int.Parse(s[0]);
            N = int.Parse(s[1]);

            int[,] mat = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(vet[j]);
                }
            }

            int X = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] == X)
                    {
                        Console.WriteLine($"Position {i}, {j}:");
                        if (j - 1 >= 0)
                        {                          
                            Console.WriteLine($"Left: {mat[i, j - 1]}");
                        }
                        if (i - 1 >= 0)
                        {
                            Console.WriteLine($"Up: {mat[i - 1, j]}");
                        }
                        if (j + 1 < N)
                        {
                            Console.WriteLine($"Right: {mat[i, j + 1]}");
                        }
                        if (i + 1 < M)
                        {
                            Console.WriteLine($"Down: {mat[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}
