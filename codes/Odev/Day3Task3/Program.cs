using System;

namespace Day3Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                Id = 1,
                FirstName = "Ali",
                LastName = "Atakay",
                IdentityNumber = "10090020043",
                CustomerNumber = "3312123"
            };

            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName = "Ahmet",
                LastName = "Atakay",
                IdentityNumber = "10090025555",
                CustomerNumber = "3315555"
            };

            CustomerManager manager = new CustomerManager();

            manager.Add(customer1);
            manager.Add(customer2);

            foreach (var customer in manager.ListAll())
            {
                Console.WriteLine(customer.Id);
            }

            Console.WriteLine("------");

            manager.Delete(customer1);

            foreach (var customer in manager.ListAll())
            {
                Console.WriteLine(customer.Id);
            }
        }
    }
}
