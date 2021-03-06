﻿using System;
using System.Collections.Generic;
using System.Linq;
using Linq_Lambda.Entities;

namespace Linq_Lambda
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { ID = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { ID = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { ID = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() { ID = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { ID = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { ID = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { ID = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { ID = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { ID = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { ID = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { ID = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { ID = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { ID = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { ID = 11, Name = "Level", Price = 70.0, Category = c1 }
            };
            
            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0); //Filtrar
            Print("TIER 1 AND PRICE < 900.0:", r1);

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name); //Projetar na forma especificada
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);

            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name); // Ordenar primeiro "por isso", depois por "aquilo"
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            var r5 = r4.Skip(2).Take(4); //Pula " " Pega " "
            Print("TIER 1 ORDER BY PRICE THEN Y NAME SKIP 2 TAKE 4", r5);

            var r6 = products.First(); //Pegar primeiro elemento
            Console.WriteLine($"First test 1: {r6}");
            Console.WriteLine();

            var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();//Pegar o primeiro elemento ou retornar nulo
            Console.WriteLine($"First or Default test 2: {r7}");
            Console.WriteLine();

            var r8 = products.Where(p => p.ID == 3).SingleOrDefault(); //Pegar um resultado ou retornar nulo
            Console.WriteLine($"Single or Default test 1: {r8}");
            Console.WriteLine();

            var r9 = products.Where(p => p.ID == 30).SingleOrDefault(); 
            Console.WriteLine($"Single or Default test 1: {r9}");
            Console.WriteLine();

            var r10 = products.Max(p => p.Price); //Pegar o máximo
            Console.WriteLine($"Max price: {r10}");
            Console.WriteLine();

            var r11 = products.Min(p => p.Price); //Pegar o mínimo
            Console.WriteLine($"Min price: {r11}");
            Console.WriteLine();

            var r12 = products.Where(p => p.Category.ID == 1).Sum(p => p.Price); //Soma
            Console.WriteLine($"Category 1 Sum prices: {r12}");
            Console.WriteLine();

            var r13 = products.Where(p => p.Category.ID == 1).Average(p => p.Price); //Média
            Console.WriteLine($"Category 1 Average prices: {r13}");
            Console.WriteLine();

            var r14 = products.Where(p => p.Category.ID == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average(); //se
            Console.WriteLine($"Category 5 Average prices: {r14}");
            Console.WriteLine();

            var r15 = products.Where(p => p.Category.ID == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine($"Category 1 Aggregate sum: {r15}");
            Console.WriteLine();

            var r16 = products.GroupBy(p => p.Category); //Agrupar
            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine($"Category: {group.Key.Name}");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}
