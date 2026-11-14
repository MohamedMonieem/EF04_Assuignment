using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF04_Assuignment.Models
{
    internal class CustomerAccount 
    {
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;




        [ForeignKey(nameof(Account))]
        public int AccNo { get; set; }
        public Account Account { get; set; } = null!;
    






    }
}
