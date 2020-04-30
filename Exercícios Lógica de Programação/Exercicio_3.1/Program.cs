using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha;

            senha = Console.ReadLine();

            while (senha != "2002")
            {
                Console.WriteLine("Senha inválida");
                senha = Console.ReadLine();
            }
            Console.WriteLine("Acesso permitido");

            Console.ReadKey();
        }
    }
}
