using System;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, duracao;

            string[] vet = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(vet[0]);
            horaFinal = int.Parse(vet[1]);

            if (horaInicial > 12 && horaFinal < 12)
            {
                duracao = 24 + horaFinal - horaInicial;
                Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
            }
            else if (horaInicial < 12 && horaFinal > 12)
            {
                duracao = horaFinal - horaInicial;
                Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
            }
            else if (horaInicial == horaFinal)
            {
                Console.WriteLine("O JOGO DUROU 24 HORAS");
            }
            Console.ReadKey();
        }
    }
}
