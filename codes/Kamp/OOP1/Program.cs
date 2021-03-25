using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product
            {
                Id = 1,
                CategoryId = 1,
                ProductName = "Masa",
                UnitPrice = 500,
                UnitsInStock = 10
            };

            Product product2 = new Product 
            {
                Id = 2,
                CategoryId = 2,
                ProductName = "Kalem",
                UnitPrice = 12,
                UnitsInStock = 40
            };

            ProductManager productManager = new ProductManager();
            productManager.Ekle(product1);
        }
    }
}
