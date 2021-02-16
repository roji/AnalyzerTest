
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class AirQualityStationParametersAnalyzerConfiguration : IEntityTypeConfiguration<AirQualityStationParametersAnalyzer>
    {
        public void Configure(EntityTypeBuilder<AirQualityStationParametersAnalyzer> builder)
        {
            builder.HasOne(q => q.AirQualityMonitoringStation).WithMany(y => y.AirQualityStationParametersAnalyzers).HasForeignKey(q => q.AirQualityMonitoringStationId);
            builder.HasOne(p => p.AirQualityMonitoringStationParameter).WithMany().HasForeignKey(f => f.AirQualityMonitoringStationParameterId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(p => p.AirQualityStationSpareParts).WithOne(p => p.AirQualityStationParametersAnalyzer).HasForeignKey(f => f.AirQualityStationParametersAnalyzerId);
            builder.HasMany(p => p.AirQualityStationConsumables).WithOne(p => p.AirQualityStationParametersAnalyzer).HasForeignKey(f => f.AirQualityStationParametersAnalyzerId);
        }
    }
}
