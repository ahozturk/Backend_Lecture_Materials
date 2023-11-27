using Microsoft.EntityFrameworkCore;
using MilanMolat.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilanMolat.Infrastructure.Contexts
{
    public class MilanMolatDbContext : DbContext
    {
        public DbSet<DefraudedPerson> DefraudedPeople { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MilanMolatDb");
        }
    }
}
