using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManagerAPI.DataCore.Configuration
{
    public static class BaseConfiguration
    {
        public static void Configure<TEntity>(EntityTypeBuilder<TEntity> builder) where TEntity : BaseEntity
        {
            builder.Property(x => x.Id).HasColumnName("id").IsRequired();
            builder.Property(x => x.DateOff).HasColumnName("date_off");
        }
    }
}
