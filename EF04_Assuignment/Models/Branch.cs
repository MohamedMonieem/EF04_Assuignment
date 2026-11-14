using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF04_Assuignment.Models
{
    internal class Branch
    {

        public int Code { get; set; }
        public string Name { get; set; } = null!;

        public String Address { get; set; } = null!;

        public int PhoneNumber { get; set; }


        // Manage Relation (1:1)   Branch <=> Manager
        public int ManagerId { get; set; }

        public Manager Manager { get; set; } = null!;


        //   Belong Relation     Brance Account (M:1)
        

        public ICollection<Account> Accounts { get; set; } = new HashSet<Account>();
         // public Account? Account { get; set; }   false branche has M accounts => Icollection



    }
}
