using System;
using System.Collections.Generic;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            //B.Remove(4); remover elemento

            //A.ExceptWith(B); A - B, ou seja, remover do A os mesmos elementos que estão em B

            //A.UnionWith(B); união de A e B

            //A.IntersectWith(B); intersecção de A e B

            foreach (int item in A)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Digite um valor inteiro: ");
            int N = int.Parse(Console.ReadLine());

            if (B.Contains(N))
            {
                Console.WriteLine($"{N} pertence ao conjunto B");
            }
            else
            {
                Console.WriteLine($"{N} pertence ao conjunto B");
            }
        }
    }
}
