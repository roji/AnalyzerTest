
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class WaterQualityMonitoringStationFacilityConfiguration : IEntityTypeConfiguration<WaterQualityMonitoringStationFacility>
    {
        public void Configure(EntityTypeBuilder<WaterQualityMonitoringStationFacility> builder)
        {
            builder.HasOne(p => p.StationUpstairsFacilityAndStructure).WithMany().HasForeignKey(f => f.StationUpstairsFacilityAndStructureId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.WaterQualityMonitoringStation).WithMany(y => y.Facilities).HasForeignKey(q => q.WaterQualityMonitoringStationId);
        }
    }
}
