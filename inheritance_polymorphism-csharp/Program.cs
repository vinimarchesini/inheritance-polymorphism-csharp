using inheritance_polimorfism_csharp.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace inheritance_polimorfism_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int qttProducts = int.Parse(Console.ReadLine());
            List<Product> productList = new List<Product>();

            for (int i = 1; i <= qttProducts; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c, u, i)? ");
                string type = Console.ReadLine();
                Console.Write("Name: ");
                string productName = Console.ReadLine();
                Console.Write("Price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (type == "c")
                {
                    Product product = new Product(productName, productPrice);
                    productList.Add(product);
                }
                else if (type == "u")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime productManufacture = DateTime.Parse(Console.ReadLine());
                    Product product = new UsedProduct(productName, productPrice, productManufacture);
                    productList.Add(product);
                }
                else if (type == "i")
                {
                    Console.Write("Custom Fee: ");
                    double productFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Product product = new ImportedProduct(productName, productPrice, productFee);
                    productList.Add(product);
                }
            }

            Console.WriteLine("Price Tags:".ToUpper());
            foreach(Product product in productList)
            {
                Console.WriteLine(product.PriceTag());
            }


        }
    }
}
