using System;
using Projeto.Model.Entities;
using Projeto.Model.Enums;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle { Color = Color.White, Radius = 2.0 };
            IShape s2 = new Retangle { Color = Color.Black, Height = 4.2, Width = 3.5 };
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
