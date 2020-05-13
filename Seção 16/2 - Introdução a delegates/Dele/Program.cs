using Dele.Services;
using System;

namespace Dele
{
    delegate double BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10.0;
            double b = 12.0;

            //BinaryNumericOperation op = CalculationService.Max;
            /////////////////////////////////////////////////Sum

            BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);

            double result = op.Invoke(a, b);
            Console.WriteLine(result);
        }
    }
}
