using ManagerAPI.DataCore.DomainModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManagerAPI.DataCore.Configuration
{
    public class ContractConfiguration : IEntityTypeConfiguration<DbContract>
    {
        public void Configure(EntityTypeBuilder<DbContract> builder)
        {
            BaseConfiguration.Configure(builder);

            builder.ToTable("contract");

            builder.Property(x => x.Name).HasColumnName("name").IsRequired();
            builder.Property(x => x.StatusId).HasColumnName("status_id");
            builder.Property(x => x.Performer).HasColumnName("performer").IsRequired();
            builder.Property(x => x.Initiator).HasColumnName("initiator");
            builder.Property(x => x.Description).HasColumnName("description").IsRequired();
            builder.Property(x => x.Note).HasColumnName("note");
            builder.Property(x => x.RequestObjectId).HasColumnName("request_object_id");
            builder.Property(x => x.ResponseObjectId).HasColumnName("response_object_id");

            builder.HasOne(x => x.RequestObject)
                .WithOne()
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(x => x.ResponseObject)
                .WithOne()
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
