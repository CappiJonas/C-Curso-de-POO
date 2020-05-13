using System;
using System.Collections.Generic;
using Pre.Entities;

namespace Pre
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            list.RemoveAll(ProductTest);

            foreach (Product product in list)
            {
                Console.WriteLine(product);
            }
        }

        public static bool ProductTest(Product p) //Predicate = referencia um objeto e retorna um booleano
        {
            return p.Price >= 100.0;
        }
    }
}
