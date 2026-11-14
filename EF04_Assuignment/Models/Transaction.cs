using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF04_Assuignment.Models
{
    internal class Transaction
    {
        public int TransNo { get; set; }
        public DateOnly TransDate { get; set; }

        public Decimal Amount { get; set; }

        public string TransType { get; set; } = null!;

        public string? Note { get; set; }



        // Related Relation between   Transaction:Account (M:1)
        public int AccountId { get; set; }

        public Account Account { get; set; } = null!;

    }
}
