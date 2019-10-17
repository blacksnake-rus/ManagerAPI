using ManagerAPI.DataCore.DomainModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManagerAPI.DataCore.Configuration
{
    public class ObjectConfiguration : BaseConfiguration<DbObject>, IEntityTypeConfiguration<DbObject>
    {
        public new void Configure(EntityTypeBuilder<DbObject> builder)
        {
            base.Configure(builder);

            builder.ToTable("object");

            builder.Property(x => x.Name).HasColumnName("name").IsRequired();
            builder.Property(x => x.TypeId).HasColumnName("type_id").IsRequired();

            builder.HasMany(x => x.ObjectProperties)
                .WithOne(x => x.ObjectOwner)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
