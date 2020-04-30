using System;
using System.Globalization;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double valor, total;

            total = 0;
            string[] vet = Console.ReadLine().Split(' ');
            codigo = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);

            switch (codigo)
            {
                case 1:
                    valor = 4.00;
                    total = quantidade * valor;
                    break;

                case 2:
                    valor = 4.50;
                    total = quantidade * valor;
                    break;

                case 3:
                    valor = 5.00;
                    total = quantidade * valor;
                    break;

                case 4:
                    valor = 4.00;
                    total = quantidade * valor;
                    break;

                case 5:
                    valor = 1.50;
                    total = quantidade * valor;
                    break;

                default:
                    Console.WriteLine("O código deve ser um número de 1 a 5");
                    break;
            }
            Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.ReadKey();
        }
    }
}
