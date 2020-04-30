using System;

namespace Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Calculaltor.Triple(ref a);
            Console.WriteLine(a);
        }
    }
}
