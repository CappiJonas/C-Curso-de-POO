using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa a, b;

            a = new Pessoa();
            b = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            a.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segundo pessoa:");
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            b.Idade = int.Parse(Console.ReadLine());

            if (a.Idade > b.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {a.Nome}");
            }
            else if (a.Idade == b.Idade)
            {
                Console.WriteLine("As duas pessoas tem a mesma idade");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {b.Nome}");
            }
        }
    }
}
