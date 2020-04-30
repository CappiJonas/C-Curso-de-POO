using System;
using System.Collections.Generic;

namespace Exercício_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos? ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A: ");            
            for (int i = 0; i < N; i++)
            {
                int M = int.Parse(Console.ReadLine());
                A.Add(M);
            }

            Console.Write("O curso B possui quantos alunos? ");
            int O = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A: ");
            for (int i = 0; i < O; i++)
            {
                int M = int.Parse(Console.ReadLine());
                A.Add(M);
            }

            Console.Write("O curso C possui quantos alunos? ");
            int P = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A: ");
            for (int i = 0; i < P; i++)
            {
                int M = int.Parse(Console.ReadLine());
                A.Add(M);
            }

            A.UnionWith(B);
            A.UnionWith(C);
            Console.WriteLine($"Total de alunos: {A.Count}");
        }
    }
}
