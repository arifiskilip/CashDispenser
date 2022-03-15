using DataAccess.Abstract;
using Entities.Concrete;
using Login.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class LogDal : ILogDal
    {
       
        public void Add(Log log)
        {
            using (CashDispenserContext context = new CashDispenserContext())
            {
                var logAdded = context.Entry(log);
                logAdded.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public List<Log> GetAll(int id)
        {
            using (CashDispenserContext context = new CashDispenserContext())
            {
                var log = context.Logs.Where(p => p.CustomerId == id);

                return log.ToList();
            }
        }
    }
}
