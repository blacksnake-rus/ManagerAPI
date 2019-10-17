using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManagerAPI.DataCore.Configuration
{
    public abstract class BaseConfiguration<TEntity>  where TEntity : BaseEntity
    {
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(x => x.Id).HasColumnName("id").IsRequired();
            builder.Property(x => x.DateOff).HasColumnName("date_off");
        }
    }
}
