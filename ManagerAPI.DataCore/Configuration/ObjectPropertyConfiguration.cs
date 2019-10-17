using ManagerAPI.DataCore.DomainModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManagerAPI.DataCore.Configuration
{
    public class ObjectPropertyConfiguration : BaseConfiguration<DbObjectProperty>, IEntityTypeConfiguration<DbObjectProperty>
    {
        public new void Configure(EntityTypeBuilder<DbObjectProperty> builder)
        {
            base.Configure(builder);

            builder.ToTable("object_property");

            builder.Property(x => x.Name).HasColumnName("name").IsRequired();
            builder.Property(x => x.DataTypeId).HasColumnName("data_type_id");
            builder.Property(x => x.ObjectOwnerId).HasColumnName("object_owner_id");
            builder.Property(x => x.IsArray).HasColumnName("is_array");
            builder.Property(x => x.IsRequired).HasColumnName("is_required");
            builder.Property(x => x.StatusId).HasColumnName("status_id");
            builder.Property(x => x.Description).HasColumnName("description");
            builder.Property(x => x.Note).HasColumnName("note");
            builder.Property(x => x.DefaultValue).HasColumnName("default_value");

            builder.HasOne(x => x.Status)
                .WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
