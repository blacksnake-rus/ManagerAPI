using ManagerAPI.DataCore.DomainModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManagerAPI.DataCore.Configuration
{
    public class GenericTypeConfiguration : IEntityTypeConfiguration<DbGenericType>
    {
        public void Configure(EntityTypeBuilder<DbGenericType> builder)
        {
            builder.Property(x => x.Name).IsRequired();

            builder.HasOne(x => x.Parent)
                .WithOne()
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
