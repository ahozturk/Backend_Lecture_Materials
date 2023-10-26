using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_7_3.Domain.Common;
using Week_7_3.Domain.Entities;

namespace Week_7_3.Persistence.Contexts
{
    public class Week_7_3DbContext : DbContext
    {
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<TaxiDriver> TaxiDrivers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Configurations.GetString("ConnectionStrings:PostgreSQL"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankAccount>()
                .HasOne(ba => ba.Owner)
                .WithOne(p => p.Account)
                .HasForeignKey<Person>(p => p.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
