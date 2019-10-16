using ManagerAPI.DataCore.DomainModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManagerAPI.DataCore.Configuration
{
    public class ObjectConfiguration : IEntityTypeConfiguration<DbObject>
    {
        public void Configure(EntityTypeBuilder<DbObject> builder)
        {
            builder.Property(x => x.Name).IsRequired();

            builder.HasMany(x => x.ObjectProperties)
                .WithOne(x => x.ObjectOwner)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
