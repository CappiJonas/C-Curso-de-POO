using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine();

            DateTime d2 = new DateTime(2020, 04, 29);
            DateTime d3 = new DateTime(2020, 04, 29, 09, 15, 30);
            DateTime d4 = new DateTime(2020, 04, 29, 09, 15, 30, 500);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine();

            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine();

            DateTime d7 = DateTime.Parse("2000-08-15");
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d9 = DateTime.Parse("29/04/2020");
            DateTime d10 = DateTime.Parse("29/04/2020 09:26:30");
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine();

            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:38", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d11);
            Console.WriteLine(d12);
        }
    }
}
