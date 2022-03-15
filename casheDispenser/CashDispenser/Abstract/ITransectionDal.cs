using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ITransectionDal
    {
        void WithdrawMoney(Customer customer); //ParaÇekme
        void DepositFunds(Customer customer); //Para yatırma
        void MoneyTransfer(Customer customer, Customer customer2); //Para transferi

    }
}
