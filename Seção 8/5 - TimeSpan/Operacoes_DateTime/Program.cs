using System;

namespace Operacoes_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine($"1) Date: {d.Date}");
            Console.WriteLine($"2)Day: {d.Day}");
            Console.WriteLine($"3)DayOfWeek: {d.DayOfWeek}");
            Console.WriteLine($"4)DayOfYear: {d.DayOfYear}");
            Console.WriteLine($"5)Hour: {d.Hour}");
            Console.WriteLine($"6)Kind: {d.Kind}");
            Console.WriteLine($"7)Milisecond: {d.Millisecond}");
            Console.WriteLine($"8)Minute: {d.Minute}");
            Console.WriteLine($"9)Month: {d.Month}");
            Console.WriteLine($"10)Second: {d.Second}");
            Console.WriteLine($"11)Ticks: {d.Ticks}");
            Console.WriteLine($"12)TimeOfDay: {d.TimeOfDay}");
            Console.WriteLine($"13)Year: {d.Year}");
            Console.WriteLine();

            //string s1 = d.ToLongDateString();
            //Console.WriteLine(s1);
            Console.WriteLine(d.ToLongDateString());
            Console.WriteLine(d.ToLongTimeString());
            Console.WriteLine(d.ToShortDateString());
            Console.WriteLine(d.ToShortTimeString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            Console.WriteLine();

            DateTime d2 = d.AddHours(2);

            DateTime d3 = d.AddMinutes(3);

            DateTime d4 = d.AddDays(7);

            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine();

            DateTime a = new DateTime(2000, 10 , 15);
            DateTime b = new DateTime(2000, 10, 18);

            TimeSpan t = b.Subtract(a);
            Console.WriteLine(t);
        }
    }
}
