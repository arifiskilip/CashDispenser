using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class Transection : ITransectionDal
    {

        public void DepositFunds(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void MoneyTransfer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void WithdrawMoney(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
