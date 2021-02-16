
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class WaterOnlineQualityMonitoringStationParametersAnalyzerConfiguration : IEntityTypeConfiguration<WaterOnlineQualityMonitoringStationParametersAnalyzer>
    {
        public void Configure(EntityTypeBuilder<WaterOnlineQualityMonitoringStationParametersAnalyzer> builder)
        {
            builder.HasOne(q => q.WaterOnlineQualityMonitoringStation).WithMany(y => y.WaterOnlineQualityMonitoringStationParametersAnalyzers).HasForeignKey(q => q.WaterOnlineQualityMonitoringStationId);
            builder.HasOne(p => p.StationParameter).WithMany().HasForeignKey(f => f.StationParameterId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(p => p.WaterOnlineQualityMonitoringStationSpareParts).WithOne(p => p.WaterOnlineQualityMonitoringStationParametersAnalyzer).HasForeignKey(f => f.WaterOnlineQualityMonitoringStationParametersAnalyzerId);
            builder.HasMany(p => p.WaterOnlineQualityMonitoringStationConsumables).WithOne(p => p.WaterOnlineQualityMonitoringStationParametersAnalyzer).HasForeignKey(f => f.WaterOnlineQualityMonitoringStationParametersAnalyzerId);
        }
    }
}
