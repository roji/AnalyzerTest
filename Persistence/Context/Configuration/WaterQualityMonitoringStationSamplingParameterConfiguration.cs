
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class WaterQualityMonitoringStationSamplingParameterConfiguration : IEntityTypeConfiguration<WaterQualityMonitoringStationSamplingParameter>
    {
        public void Configure(EntityTypeBuilder<WaterQualityMonitoringStationSamplingParameter> builder)
        {
            builder.HasOne(p => p.Monitoring).WithMany().HasForeignKey(f => f.MonitoringId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.WaterQualityMonitoringStationSamplingResult).WithMany(q => q.SamplingParameters).HasForeignKey(q => q.WaterQualityMonitoringStationSamplingResultId);
        }
    }
}
