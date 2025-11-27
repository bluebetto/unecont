using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UneCont.Domain.Entities;

namespace UneCont.Infra.Configuration
{
    public class ProviderConfiguration : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
        {
            builder.ToTable("Providers");

            builder.Property(p => p.Cnpj).IsRequired();

            builder.HasOne(b => b.Invoice)
                .WithOne(i => i.Provider)
                .HasForeignKey<Provider>(i => i.InvoiceId);
        }
    }
}
