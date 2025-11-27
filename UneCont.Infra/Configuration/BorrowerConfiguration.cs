using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UneCont.Domain.Entities;

namespace UneCont.Infra.Configuration
{
    public class BorrowerConfiguration : IEntityTypeConfiguration<Borrower>
    {
        public void Configure(EntityTypeBuilder<Borrower> builder)
        {
            builder.ToTable("Borrowers");

            builder.Property(b => b.Cnpj).IsRequired();

            builder.HasOne(b => b.Invoice)
                .WithOne(i => i.Borrower)
                .HasForeignKey<Borrower>(i => i.InvoiceId);
        }
    }
}
