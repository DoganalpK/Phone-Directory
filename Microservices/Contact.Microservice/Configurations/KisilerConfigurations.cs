using Contact.Microservice.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Contact.Microservice.Configurations
{
    public class KisilerConfigurations : IEntityTypeConfiguration<Models.Domain.Kisiler>
    {
        public void Configure(EntityTypeBuilder<Kisiler> builder)
        {
            builder.HasKey(x => x.UUID);
            builder.Property(x => x.UUID).IsRequired();
            builder.Property(x=> x.Ad).HasMaxLength(64);
            builder.Property(x=> x.Soyad).HasMaxLength(64);
        }
    }
}
