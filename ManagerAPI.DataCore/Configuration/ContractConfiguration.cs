using ManagerAPI.DataCore.DomainModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManagerAPI.DataCore.Configuration
{
    public class ContractConfiguration : IEntityTypeConfiguration<DbContract>
    {
        public void Configure(EntityTypeBuilder<DbContract> builder)
        {
            builder.Property(x => x.Name).IsRequired();

            builder.Property(x => x.Performer).IsRequired();

            builder.Property(x => x.Description).IsRequired();

            builder.HasOne(x => x.RequestObject)
                .WithOne()
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(x => x.ResponseObject)
                .WithOne()
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
