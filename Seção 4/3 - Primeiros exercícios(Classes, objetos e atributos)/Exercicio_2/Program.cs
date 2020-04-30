using System;
using System.Globalization;

namespace Exercicio_2
{
    class Program
    {        
        static void Main(string[] args)
        {
            Funcionario a, b;
            double mediaSalario;

            a = new Funcionario();
            b = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            a.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            b.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            mediaSalario = (a.Salario + b.Salario) / 2.0;
            Console.WriteLine($"Salário médio = {mediaSalario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
