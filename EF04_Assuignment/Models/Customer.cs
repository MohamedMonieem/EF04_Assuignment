using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF04_Assuignment.Models
{
    internal class Customer
    {
        public int Id { get; set; }

        public String Address { get; set; } = null!;
        public DateOnly DOB { get; set; }

        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int PhoneNumber { get; set; }

        public string CustomerType { get; set; } = null!;

        public int NationalId { get; set; }


        // Customer Account <=> Customer
        public ICollection<CustomerAccount> CustomerAccounts { get; set; } = new HashSet<CustomerAccount>();


    }
}
