using System;

namespace Extension_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2020, 5, 13, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
