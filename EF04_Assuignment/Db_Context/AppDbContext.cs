using EF04_Assuignment.Configuration;
using EF04_Assuignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF04_Assuignment.Db_Context
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Bank System;Trusted_Connection = true; TrustServerCertificate = true; ");
        }

        // Dbsets
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<CustomerAccount> CustomerAccounts { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<CustomerAccount>(new CustomerAccountConfig());
            modelBuilder.ApplyConfiguration<Account> (new Account_Config());
            modelBuilder.ApplyConfiguration<Branch>(new Branch_Config()) ;
            modelBuilder.ApplyConfiguration<Transaction>(new Transaction_Config());
            modelBuilder.ApplyConfiguration<Manager>(new Manager_Config());

        }

    }
}
