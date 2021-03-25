using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new IndividualCustomer
            {
                Id = 1,
                FirstName = "Ali",
                LastName = "Atakay"
            };

            Customer customer2 = new CorporateCustomer
            {
                Id = 2,
                CompanyName = "Company",
                TaxNumber = "110774"
            };

            CustomerManager manager = new CustomerManager();
            manager.Add(customer1);
            manager.Add(customer2);
        }
    }
}
