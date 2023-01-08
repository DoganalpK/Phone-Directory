using Contact.Microservice.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Contact.Microservice.Configurations
{
    public class IletisimBilgileriConfiguration : IEntityTypeConfiguration<Models.Domain.IletisimBilgileri>
    {
        public void Configure(EntityTypeBuilder<IletisimBilgileri> builder)
        {
            builder.HasKey(x => x.UUID);
            builder.Property(x=> x.UUID).IsRequired();
            builder.HasOne(x => x.Kisiler).WithMany(x => x.IletisimBilgileris).HasForeignKey(x => x.KisilerUUID);
        }
    }
}
