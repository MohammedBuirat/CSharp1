using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Csharp1
{
    internal class Inventory
    {
        private Dictionary<string, Product> Products;

        public Inventory()
        {
            Products = new Dictionary<string, Product>();
        }

        public bool AddProduct(Product product)
        {
            if (Products.ContainsKey(product.Name))
            {
                return false;
            }
            else
            {
                Products.Add(product.Name, product);
                return true;
            }
        }

        public bool EditProduct(string name, string? newName, decimal? price, int? quantity)
        {
            if (!Products.ContainsKey(name) || (newName != null && Products.ContainsKey(newName)))
            {
                return false;
            }
            else
            {
                Product product = new Product();
                product.Price = (price == null) ? Products[name].Price : (decimal)price;
                product.Quantity = (quantity == null) ? Products[name].Quantity : (int)quantity;
                product.Name = (newName == null) ? Products[name].Name : newName;
                Products.Remove(name);
                Products.Add(product.Name, product);
                return true;
            }
        }

        public Product? GetProduct(string name)
        {
            if (!Products.ContainsKey(name)) return null;
            else return Products[name];
        }

        public bool DeleteProduct(string name)
        {
            if (!Products.ContainsKey(name)) return false;
            Products.Remove(name);
            return true;
        }

        public Product? SearchProduct(string name)
        {
            return (Products.ContainsKey(name)) ? Products[name] : null;
        }

        public List<Product>? RetriveProducts()
        {
            return Products.Values.ToList();
        }
    }
}
