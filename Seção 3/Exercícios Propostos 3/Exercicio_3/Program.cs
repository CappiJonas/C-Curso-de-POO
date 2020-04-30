using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipoCombustivel, contGasolina, contAlcool, contDiesel;

            contAlcool = 0;
            contGasolina = 0;
            contDiesel = 0;
            tipoCombustivel = int.Parse(Console.ReadLine());

            while(tipoCombustivel != 4)
            {
                switch (tipoCombustivel)
                {
                    case 1:
                        contAlcool++;
                        break;

                    case 2:
                        contGasolina++;
                        break;

                    case 3:
                        contDiesel++;
                        break;
                }
                tipoCombustivel = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Muito Obrigado");
            Console.WriteLine($"Alcool: {contAlcool}");
            Console.WriteLine($"Gasolina: {contGasolina}");
            Console.WriteLine($"Diesel: {contDiesel}");
            Console.ReadKey();
        }
    }
}
