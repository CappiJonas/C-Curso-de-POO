using System;
using System.Collections.Generic;
using System.Linq;
using Linq_SQL.Entities;

namespace Linq_SQL
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

            //var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0); 
            var r1 =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900.0
                select p;
            Print("TIER 1 AND PRICE < 900.0:", r1);

            //var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name); 
            var r2 =
                from p in products
                where p.Category.Name == "Tools"
                select p.Name;
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);

            //var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            var r3 =
                from p in products
                where p.Name[0] == 'C'
                select new { p.Name, p.Price, CategoryName = p.Category.Name };
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

            //var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            var r4 =
                from p in products
                where p.Category.Tier == 1
                orderby p.Name //inverso
                orderby p.Price
                select p;
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            //var r5 = r4.Skip(2).Take(4); 
            var r5 =
                (from p in r4
                 select p).Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            //var r16 = products.GroupBy(p => p.Category);
            var r16 =
                from p in products
                group p by p.Category;
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
