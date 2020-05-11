using System.Globalization;

namespace Exercicio_Fixacao.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double Total()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return $"{Name}, $ {Total().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
