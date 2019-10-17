using ManagerAPI.DataCore.DomainModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManagerAPI.DataCore.Configuration
{
    public class GenericTypeConfiguration : BaseConfiguration<DbGenericType>, IEntityTypeConfiguration<DbGenericType>
    {
        public new void Configure(EntityTypeBuilder<DbGenericType> builder)
        {
            base.Configure(builder);

            builder.ToTable("generic_type");

            builder.Property(x => x.Name).HasColumnName("name").IsRequired();
            builder.Property(x => x.ParentId).HasColumnName("parent_id");

            builder.HasOne(x => x.Parent)
                .WithOne()
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
