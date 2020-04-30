using System;
using System.Globalization;

namespace Exercicio_Proposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta_Bancaria conta = new Conta_Bancaria();

            Console.Write("Entre o número da conta: ");
            conta.NumeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            conta.Nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            string escolha = Console.ReadLine();
            double valorInicial = 0.0;
            do
            {               
                if (escolha == "s")
                {
                    Console.Write("Entre o valor do depósito inicial: ");
                    valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    conta.ValorInicial(valorInicial);
                }
                else if (escolha == "n")
                {
                    valorInicial = 0.0;
                    conta.ValorInicial(valorInicial);
                }
                else
                {
                    Console.WriteLine("A escolha deve ser SIM(s) ou NÃO(n).");
                    escolha = Console.ReadLine();
                }
            } while (escolha != "s" && escolha != "n");                            
            Console.WriteLine();

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}
