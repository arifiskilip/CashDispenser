using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class CustomerDal : ICustomerDal
    {
        List<Customer> _customers;
        public CustomerDal()
        {
            _customers = new List<Customer>
            {
                new Customer{Id=1,FirstName="Arif",LastName="İskilip",Gender="Erkek",Password="123456",NationalIdentityNumber="123456"},
                new Customer{Id=2,FirstName="Gamze",LastName="Işıldak",Gender="Kadın",Password="123456",NationalIdentityNumber="111111"}
            };
        }
        public void Add(Customer customer)
        {
            _customers.Add(customer);
        }

        public void Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
