using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Concrete
{
    public class CashDispenserContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}
