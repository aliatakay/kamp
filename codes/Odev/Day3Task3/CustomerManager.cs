using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day3Task3
{
    public class CustomerManager
    {
        List<Customer> _customers;

        public CustomerManager()
        {
            _customers = new List<Customer>();
        }
        public void Add(Customer customer)
        {
            _customers.Add(customer);
        }

        public List<Customer> ListAll()
        {
            return _customers;
        }

        public void Delete(Customer customer)
        {
            Customer deleted = _customers.SingleOrDefault(c => c.Id == customer.Id);
            _customers.Remove(deleted);
        }
    }
}
