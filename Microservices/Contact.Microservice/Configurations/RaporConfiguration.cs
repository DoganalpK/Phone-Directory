using Contact.Microservice.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Contact.Microservice.Configurations
{
    public class RaporConfiguration : IEntityTypeConfiguration<Models.Domain.Rapor>
    {
        public void Configure(EntityTypeBuilder<Rapor> builder)
        {
            builder.HasKey(x => x.UUID);
            builder.Property(x=> x.UUID).IsRequired();
        }
    }
}
