
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class RepositoryConfiguration : IEntityTypeConfiguration<Repository>
    {
        public void Configure(EntityTypeBuilder<Repository> builder)
        {
            builder.Property(q => q.Name).IsRequired().HasMaxLength(255);
            builder.HasOne(q => q.RlessUnitMeasurement).WithMany().HasForeignKey(q => q.RlessUnitMeasurementId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.RssUnitMeasurement).WithMany().HasForeignKey(q => q.RssUnitMeasurementId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.Industry).WithMany(y => y.Repositories).HasForeignKey(q => q.IndustryId);
        }
    }
}
