using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1
{
    internal class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(String Name, decimal Price, int Quantity)
        {
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
        }

        public Product() { }

        public override String ToString()
        {
            return $"Name: {Name}   price: {Price}    quantity:{Quantity}";
        }

        public override bool Equals(object? obj)
        {
            if (obj.GetType != GetType || obj == null) return false;
            Product other = obj as Product;
            if (Name == other.Name &&
                Quantity == other.Quantity &&
                Price == other.Price)
            {
                return true;
            }
            return false;

        }

    }
}
