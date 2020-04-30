using System;

namespace Ref_Valor
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;
            p = new Point();
            Console.WriteLine(p);
            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);
            

        }
    }
}
