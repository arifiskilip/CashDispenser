using DataAccess.Abstract;
using Entities.Concrete;
using Login.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DataAccess.Concrete
{
    public class Transection : ITransectionDal
    {

        public void DepositFunds(Customer customer)
        {
            using (CashDispenserContext context = new CashDispenserContext())
            {
                var updated = context.Entry(customer);
                updated.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void MoneyTransfer(Customer customer, Customer customer2)
        {
            using (CashDispenserContext context = new CashDispenserContext())
            {
                var updated = context.Entry(customer);
                var updated2 = context.Entry(customer2);
                updated.State = EntityState.Modified;
                updated2.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void WithdrawMoney(Customer customer)
        {
            using (CashDispenserContext context = new CashDispenserContext())
            {
                var updated = context.Entry(customer);
                updated.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
