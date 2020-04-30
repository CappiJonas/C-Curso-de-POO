using System;
using System.Globalization;

namespace Secao_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto produto = new Produto("TV", 500.0, 10);

            produto.SetNome(Console.ReadLine());

            Console.WriteLine(produto.GetNome());
        }
    }
}
