using System;
using System.Collections.Generic;

namespace Day2Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Product product1 = new Product
            {
                Id = 1,
                CategoryId = 1,
                ProductName = "Masa",
                UnitPrice = 500,
                UnitsInStock = 50
            };

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 2,
                ProductName = "Bardak",
                UnitPrice = 15,
                UnitsInStock = 90
            };

            products.Add(product1);
            products.Add(product2);


            Console.WriteLine("Foreach Loop");

            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("--------");
            Console.WriteLine("For Loop");

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(products[i].ProductName);
            }

            Console.WriteLine("--------");
            Console.WriteLine("While Loop");

            int index = 0;
            while (index < products.Count)
            {
                Console.WriteLine(products[index].ProductName);
                index++;
            }
        }
    }
}
