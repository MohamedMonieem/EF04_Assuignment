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
    internal class Transaction_Config : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(a=>a.TransNo);
            builder.HasOne(a=>a.Account).WithMany(b=>b.Transactions).HasForeignKey(a=>a.AccountId);
        }
    }
}
