using System;
using System.Globalization;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] num = new double[N];

            for (int i = 0; i < N; i++)
            {
                num[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma += num[i];
            }

            double media = soma / N;

            Console.WriteLine($"AVERAGE HEIGHT {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
