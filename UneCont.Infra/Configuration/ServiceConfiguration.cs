using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UneCont.Domain.Entities;

namespace UneCont.Infra.Configuration
{
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable("Services");
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Description).IsRequired().HasMaxLength(200);
            builder.Property(s => s.Value).IsRequired();
        }
    }
}
