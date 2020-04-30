using System;
using System.Globalization;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] numero, media;

            N = int.Parse(Console.ReadLine());
            numero = new double[3];
            media = new double[N];

            for (int i = 0; i < N; i++)
            {
                string[] S = Console.ReadLine().Split(' ');
                numero[0] = double.Parse(S[0], CultureInfo.InvariantCulture);
                numero[1] = double.Parse(S[1], CultureInfo.InvariantCulture);
                numero[2] = double.Parse(S[2], CultureInfo.InvariantCulture);

                media[i] = (numero[0] * 2.0 + numero[1] * 3.0 + numero[2] * 5.0) / 10.0;
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(media[i].ToString("F1", CultureInfo.InvariantCulture));
            }
            Console.ReadKey();
        }
    }
}
