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
    internal class CustomerAccountConfig : IEntityTypeConfiguration<CustomerAccount>
    {
        public void Configure(EntityTypeBuilder<CustomerAccount> builder)
        {
            builder.HasKey(x => new { x.AccNo, x.CustomerId });     // composite pr key

            builder.HasOne(a => a.Account)
                    .WithMany(a => a.Accounts)
                    .HasForeignKey(a => a.AccNo);

            builder.HasOne(a => a.Customer)
                .WithMany(a => a.CustomerAccounts)
                .HasForeignKey(a => a.CustomerId);

        }
    }
}
