using Microsoft.EntityFrameworkCore;
using UneCont.Domain.Entities;

namespace UneCont.Infra.Context
{
    public class UneContDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UneContDbContext).Assembly);
        }
    }
}
