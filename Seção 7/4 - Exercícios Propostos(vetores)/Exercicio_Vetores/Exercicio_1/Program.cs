using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented?" );
            int N = int.Parse(Console.ReadLine());
            while (N < 1 || N > 10)
            {
                Console.WriteLine("We just have 10 rooms. Choose a valid number.");
                N = int.Parse(Console.ReadLine());
            }           
            Estudante[] vet = new Estudante[10];
            Console.WriteLine();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Rent #{i}");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                while (room < 0 || room > 9)
                {
                    Console.WriteLine("The number of the rooms are 0 to 9. Choose a number between them.");
                    room = int.Parse(Console.ReadLine());
                }
                vet[room] = new Estudante { Name = name, Email = email };
                Console.WriteLine();
            }

            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < 10; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine($"{i}: {vet[i].Name}, {vet[i].Email}");
                }
            }
        }
    }
}
