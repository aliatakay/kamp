using System;

namespace Day5Task5
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
                IdentityNumber = "22098090020",
                DateOfBirth = new DateTime(1996, 03, 29)
            };

            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName = "Ahmet",
                LastName = "Atasoy",
                IdentityNumber = "12345678910",
                DateOfBirth = new DateTime(1994, 04, 12)
            };

            CustomerManager customerManager = new CustomerManager(new EDevletValidationManager());
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            foreach (var customer in customerManager.Show)
            {
                Console.WriteLine(customer.IdentityNumber);
            }

            customerManager.Delete(customer1);

            foreach (var customer in customerManager.Show)
            {
                Console.WriteLine(customer.IdentityNumber);
            }
        }
    }
}
