
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class AirQualityStationMeteorologicalSystemConfiguration : IEntityTypeConfiguration<AirQualityStationMeteorologicalSystem>
    {
        public void Configure(EntityTypeBuilder<AirQualityStationMeteorologicalSystem> builder)
        {
            builder.HasOne(q => q.AirQualityMonitoringStation).WithMany(y => y.AirQualityStationMeteorologicalSystems).HasForeignKey(q => q.AirQualityMonitoringStationId);
            builder.HasOne(p => p.StationMeteorologicalSystem).WithMany().HasForeignKey(f => f.StationMeteorologicalSystemId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
