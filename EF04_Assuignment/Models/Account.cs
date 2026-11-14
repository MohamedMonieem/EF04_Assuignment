using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF04_Assuignment.Models
{
    internal class Account
    {
        public int AccountNumber { get; set; }
        public Decimal CurrentBalance { get; set; }

        public string AccountType { get; set; } = null!;

        public DateOnly OpeningDate { get; set; }



        //   Belong Relation   between  Brance:Account (M:1)  
        public int BranchId { get; set; }               

        public Branch Branch { get; set; } = null!;



        // Related Relation between   Transaction:Account (M:1)
        public ICollection<Transaction> Transactions { get; set; } = new HashSet<Transaction>();



        // Customer Account <=> Account
        public ICollection<CustomerAccount> Accounts { get; set; } = new HashSet<CustomerAccount>();
      

    }

}
