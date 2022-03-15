using DataAccess.Abstract;
using Entities.Concrete;
using Login.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DataAccess.Concrete
{
    public class CustomerDal : ICustomerDal
    {
        List<Customer> _customers;
        public CustomerDal()  //inmemory test
        {
            _customers = new List<Customer>
            {
                new Customer{Id=1,FirstName="Arif",LastName="İskilip",Gender="Erkek",Password="123456",NationalIdentityNumber="123456"},
                new Customer{Id=2,FirstName="Gamze",LastName="Işıldak",Gender="Kadın",Password="123456",NationalIdentityNumber="111111"}
            };
        }
        public void Add(Customer customer)
        {
            using (CashDispenserContext context = new CashDispenserContext())
            {
                var adedCustomer = context.Entry(customer);
                adedCustomer.State = EntityState.Added;
                context.SaveChanges();

                
            }
        }

        public void Delete(Customer customer)
        {
            using (CashDispenserContext context = new CashDispenserContext())
            {
                var deletedCustomer = context.Entry(customer);
                deletedCustomer.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Customer> GetAll()
        {
            return _customers;
        }

        public void Update(Customer customer)
        {
            using (CashDispenserContext context = new CashDispenserContext())
            {
                var updatedCustomer = context.Entry(customer);
                updatedCustomer.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
