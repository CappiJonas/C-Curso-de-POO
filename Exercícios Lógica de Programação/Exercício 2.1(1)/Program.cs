using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2._1_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            double COD, quantidade, preco;

            Console.WriteLine("Segue o tabela de códigos, especificação e preços" +
                              "do que é verndido no restaurante ");

            Console.WriteLine();

            Console.WriteLine("1 Cachorro Quente R$ 4,00");
            Console.WriteLine("2 X-Salada        R$ 4,50");
            Console.WriteLine("3 X-Bacon         R$ 5,00");
            Console.WriteLine("4 Torrada simples R$ 2,00");
            Console.WriteLine("5 Refrigerante    R$ 1,00");
            Console.ReadKey();

            Console.WriteLine();

            do
            {
                Console.WriteLine("Utilizando o código qual será o seu pedido sabendo que você" +
                              "só pode escolher um item, porém qualquer quantidade?");
                COD = double.Parse(Console.ReadLine());
            } 
            while (COD == 0 || COD > 5);
            Console.ReadKey();

            Console.WriteLine();

            Console.WriteLine("Qual a quantidade desejada? ");
            quantidade = double.Parse(Console.ReadLine());
            
            Console.WriteLine();

            switch (COD)
            {
                case 1:
                    preco = quantidade * 4.0;
                    Console.WriteLine("O preço a ser pago é " + preco);
                    break;

                case 2:
                    preco = quantidade * 4.5;
                    Console.WriteLine("O preço a ser pago é " + preco);
                    break;

                case 3:
                    preco = quantidade * 5.0;
                    Console.WriteLine("O preço a ser pago é " + preco);
                    break;

                case 4:
                    preco = quantidade * 2.0;
                    Console.WriteLine("O preço a ser pago é " + preco);
                    break;

                case 5:
                    preco = quantidade * 1.0;
                    Console.WriteLine("O preço a ser pago é " + preco);
                    break;
            }
            Console.ReadKey();
        }
    }
}
