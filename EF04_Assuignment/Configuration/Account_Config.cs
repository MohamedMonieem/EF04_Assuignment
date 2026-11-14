using EF04_Assuignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF04_Assuignment.Configuration
{
    internal class Account_Config : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)

        {
            builder.HasKey(a => a.AccountNumber);
            builder.HasOne(a => a.Branch).WithMany(b => b.Accounts).HasForeignKey(a => a.BranchId);
                    
        }
    }
}
