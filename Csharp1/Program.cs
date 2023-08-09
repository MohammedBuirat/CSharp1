using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1
{
    internal class Program
    {
        static void AddProduct(ref Inventory inventory)
        {
            Console.WriteLine("Please enter the new product name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter the new product price:");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the new product quantity:");
            int quantity = int.Parse(Console.ReadLine());
            if (inventory.AddProduct(new Product(name, price, quantity)))
            {
                Console.WriteLine("Product added successfully");
            }
            else
            {
                Console.WriteLine("Product alredy exists");
            }
        }

        static void removeProduct(ref Inventory inventory)
        {
            Console.WriteLine("Please enter the name of the Product");
            string name = Console.ReadLine();
            if (inventory.DeleteProduct(name))
            {
                Console.WriteLine("Product deleted successfully");
            }
            else
            {
                Console.WriteLine("Product with the given name does not exist");
            }
        }

        static void ViewProduct(ref Inventory inventory)
        {
            List<Product>? products = inventory.RetriveProducts();
            if (products == null)
            {
                Console.WriteLine("Inventory is empty");
            }
            else
            {
                foreach (var product in products)
                {
                    product.ToString();
                }
            }
        }

        static void EditProduct(ref Inventory inventory)
        {
            Console.WriteLine("Please enter the product that you want to edit name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter the product new name:");
            string newNmae = Console.ReadLine();
            Console.WriteLine("Please enter the product new price:");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the product new quantity:");
            int quantity = int.Parse(Console.ReadLine());
            if (inventory.EditProduct(name, newNmae, price, quantity))
            {
                Console.WriteLine("Product name was updated");
            }
            else
            {
                Console.WriteLine("either the name does not exist or you entered a invalid value");
            }

        }

        static void SearchProduct(ref Inventory inventory)
        {

        }
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            int option = 0;
            while (option != 6)
            {
                Console.WriteLine("Please pick an option");
                Console.WriteLine("1) Add a product.");
                Console.WriteLine("2) View all products.");
                Console.WriteLine("3) Edit a product.");
                Console.WriteLine("4) Delete a product.");
                Console.WriteLine("5) Search for a product.");
                Console.WriteLine("6) Exit.");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddProduct(ref inventory);
                        break;
                    case 2:
                        ViewProduct(ref inventory);
                        break;
                    case 3:
                        EditProduct(ref inventory);
                        break;
                    case 4:
                        removeProduct(ref inventory);
                        break;
                    case 5:
                        SearchProduct(ref inventory);
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("please enter a vaild option");
                        break;

                }
                Console.WriteLine("\n\n");
            }
        }
    }
}
