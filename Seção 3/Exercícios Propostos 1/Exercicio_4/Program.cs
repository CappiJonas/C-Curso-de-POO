using System;
using System.Globalization;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, horas;
            double valor, salario;

            numero = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horas * valor;
            Console.WriteLine($"NUMBER = {numero}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.ReadKey();
        }
    }
}
