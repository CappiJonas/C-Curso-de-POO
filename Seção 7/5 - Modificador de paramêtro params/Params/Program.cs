using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum( 10, 20, 30, 40 );

            Console.WriteLine(s1);
        }
    }
}
