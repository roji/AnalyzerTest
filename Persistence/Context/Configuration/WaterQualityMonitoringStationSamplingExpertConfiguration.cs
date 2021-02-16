
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class WaterQualityMonitoringStationSamplingExpertConfiguration : IEntityTypeConfiguration<WaterQualityMonitoringStationSamplingExpert>
    {
        public void Configure(EntityTypeBuilder<WaterQualityMonitoringStationSamplingExpert> builder)
        {
            builder.HasOne(q => q.WaterQualityMonitoringStationSamplingResult).WithMany(q => q.SamplingExperts).HasForeignKey(q => q.WaterQualityMonitoringStationSamplingResultId);
        }
    }
}
