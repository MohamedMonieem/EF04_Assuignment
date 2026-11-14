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
    internal class Manager_Config : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.HasData(
                new Manager { Id = 500, FullName = "mohamed", Email = "mohamed@gmail.com", PhoneNumber = 123, HireDate = new DateOnly(2020,1,1) } ,
                new Manager { Id = 501, FullName = "ali", Email = "ali@gmail.com", PhoneNumber = 123,  HireDate = new DateOnly(2020, 1, 1) }
                );
        }
    }
}
