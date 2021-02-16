
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class WaterQualityMonitoringStationRiverUsageConfiguration : IEntityTypeConfiguration<WaterQualityMonitoringStationRiverUsage>
    {
        public void Configure(EntityTypeBuilder<WaterQualityMonitoringStationRiverUsage> builder)
        {
            builder.HasOne(p => p.RiverUsage).WithMany().HasForeignKey(f => f.RiverUsageId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.WaterQualityMonitoringStation).WithMany(y => y.RiverUsages).HasForeignKey(q => q.WaterQualityMonitoringStationId);
        }
    }
}
