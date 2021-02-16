
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class WaterQualityMonitoringStationClosedYearConfiguration : IEntityTypeConfiguration<WaterQualityMonitoringStationClosedYear>
    {
        public void Configure(EntityTypeBuilder<WaterQualityMonitoringStationClosedYear> builder)
        {
            builder.HasOne(q => q.WaterQualityMonitoringStation).WithMany(y => y.ClosedYears).HasForeignKey(q => q.WaterQualityMonitoringStationId);
        }
    }
}
