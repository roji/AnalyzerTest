
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class WaterOnlineQualityMonitoringStationSparePartConfiguration : IEntityTypeConfiguration<WaterOnlineQualityMonitoringStationSparePart>
    {
        public void Configure(EntityTypeBuilder<WaterOnlineQualityMonitoringStationSparePart> builder)
        {
            builder.HasOne(q => q.WaterOnlineQualityMonitoringStationParametersAnalyzer).WithMany(y => y.WaterOnlineQualityMonitoringStationSpareParts).HasForeignKey(q => q.WaterOnlineQualityMonitoringStationParametersAnalyzerId);
            builder.HasOne(p => p.StationSparePart).WithMany().HasForeignKey(f => f.StationSparePartId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
