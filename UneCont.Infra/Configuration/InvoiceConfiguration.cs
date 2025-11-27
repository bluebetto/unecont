using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UneCont.Domain.Entities;

namespace UneCont.Infra.Configuration
{
    public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.ToTable("Invoices");
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Number).IsRequired();
            builder.Property(i => i.EmissionDate).IsRequired();

            builder.HasIndex(i => i.Number).IsUnique().HasDatabaseName("IX_Invoice_Number");

            builder
                .HasOne(i => i.Provider)
                .WithMany(p => p.Invoices)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(i => i.Borrower)
                .WithMany(b => b.Invoices)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(i => i.Service)
                .WithOne(s => s.Invoice)
                .HasForeignKey<Service>(s => s.InvoiceId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
