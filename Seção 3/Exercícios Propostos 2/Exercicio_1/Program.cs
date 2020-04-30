using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;

            escolha = int.Parse(Console.ReadLine());

            if (escolha < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NAO NEGATIVO");
            }
            Console.ReadKey();
        }
    }
}
