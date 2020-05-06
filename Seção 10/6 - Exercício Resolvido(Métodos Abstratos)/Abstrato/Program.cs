using System;
using System.Globalization;
using System.Collections.Generic;
using Abstrato.Entities;
using Abstrato.Entities.Enums;

namespace Abstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> Shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Retangle or Circle (r/c)? ");
                string choose = Console.ReadLine();

                while (choose != "r" && choose != "c")
                {
                    Console.Write("You need to choose a valid shape: 'r' for 'retangle' or 'c' for circle." +
                                      "Choose again: ");
                    choose = Console.ReadLine();
                }

                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (choose == "r")
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Shape retangle = new Rectangle(color, width, height);
                    Shapes.Add(retangle);
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Shape circle = new Circle(color, radius);
                    Shapes.Add(circle);
                }                
            }
            Console.WriteLine();

            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape shape in Shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
