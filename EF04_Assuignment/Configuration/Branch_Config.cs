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
    internal class Branch_Config : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.HasKey(k => k.Code);
            builder.Property(a=>a.Name).IsRequired().HasMaxLength(100);

            // Manage Relation (1:1)   Branch <=> Manager
            builder.HasOne(a=>a.Manager).WithOne(b=>b.Branch).HasForeignKey<Branch>(a=>a.ManagerId);


            // seeding data 
            builder.HasData(
                new Branch { Code = 1, Name = "EgyptBank", Address = "Egypt", PhoneNumber = 123 , ManagerId=500 },
                new Branch { Code = 2, Name = "KSABank", Address = "KSA", PhoneNumber = 456 , ManagerId=501 }
                );

        }
    }
}
