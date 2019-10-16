using ManagerAPI.DataCore.DomainModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManagerAPI.DataCore.Configuration
{
    public class ObjectPropertyConfiguration : IEntityTypeConfiguration<DbObjectProperty>
    {
        public void Configure(EntityTypeBuilder<DbObjectProperty> builder)
        {
            builder.Property(x => x.Name).IsRequired();

            builder.HasOne(x => x.Status)
                .WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
