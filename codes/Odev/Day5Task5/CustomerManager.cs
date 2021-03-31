using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day5Task5
{
    public class CustomerManager
    {
        List<Customer> _customers;
        IPersonValidationService _personValidationService;

        public CustomerManager(IPersonValidationService personValidationService)
        {
            _customers = new List<Customer>();
            _personValidationService = personValidationService;
        }

        public void Add(Customer customer)
        {
            if (_personValidationService.CheckIfRealPerson(customer))
            {
                _customers.Add(customer);
                Console.WriteLine(customer.Id + " Numaralı Müşteri Eklendi");
            }

            else
            {
                Console.WriteLine(customer.Id + " Numaralı Müşterinin Kimlik Bilgileri Doğrulanamadı");
            }
        }

        public void Delete(Customer customer)
        {
            var deletedCustomer = _customers.SingleOrDefault(c => c.Id == customer.Id);
            if (deletedCustomer != null)
            {
                _customers.Remove(deletedCustomer);
                Console.WriteLine(customer.Id + " Numaralı Müşteri Silindi");
            }
            else
            {
                Console.WriteLine(customer.Id + " Numaralı Müşteri Bulunamadı");
            }
        }

        public void Update(Customer customer)
        {
            var updatedCustomer = _customers.SingleOrDefault(c => c.Id == customer.Id);

            if (_personValidationService.CheckIfRealPerson(customer))
            {
                updatedCustomer.FirstName = customer.FirstName;
                updatedCustomer.LastName = customer.LastName;
                updatedCustomer.IdentityNumber = customer.IdentityNumber;
                updatedCustomer.DateOfBirth = customer.DateOfBirth;
                Console.WriteLine(customer.Id + " Numaralı Müşteri Güncellendi");
            }
            else
            {
                Console.WriteLine(customer.Id + " Numaralı Müşterinin Kimlik Bilgileri Doğrulanamadı");
            }

        }

        public List<Customer> Show => _customers;
    }
}
