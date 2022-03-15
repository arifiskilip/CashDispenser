using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public decimal Money { get; set; }
        public string Gender { get; set; }
        public string NationalIdentityNumber { get; set; }
    }
}
