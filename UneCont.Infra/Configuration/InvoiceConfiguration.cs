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

            
        }
    }
}
