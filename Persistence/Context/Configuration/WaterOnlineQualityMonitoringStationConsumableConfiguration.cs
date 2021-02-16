
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class WaterOnlineQualityMonitoringStationConsumableConfiguration : IEntityTypeConfiguration<WaterOnlineQualityMonitoringStationConsumable>
    {
        public void Configure(EntityTypeBuilder<WaterOnlineQualityMonitoringStationConsumable> builder)
        {
            builder.HasOne(q => q.WaterOnlineQualityMonitoringStationParametersAnalyzer).WithMany(y => y.WaterOnlineQualityMonitoringStationConsumables).HasForeignKey(q => q.WaterOnlineQualityMonitoringStationParametersAnalyzerId);
            builder.HasOne(p => p.StationConsumable).WithMany().HasForeignKey(f => f.StationConsumableId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
