﻿using System;
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
            
        }

        static void removeProduct(ref Inventory inventory)
        {
            
        }

        static void ViewProduct(ref Inventory inventory)
        {
            
        }

        static void EditProduct(ref Inventory inventory)
        {
            

        }

        static void SearchProduct(ref Inventory inventory)
        {
            
        }
        static void Main(string[] args)
        {
            Inventory inventory= new Inventory();
            int option = 0;
            while (option!=6)
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
