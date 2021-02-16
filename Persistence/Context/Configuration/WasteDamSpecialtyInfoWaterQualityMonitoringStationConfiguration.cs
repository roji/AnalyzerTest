
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class WasteDamSpecialtyInfoWaterQualityMonitoringStationConfiguration : IEntityTypeConfiguration<WasteDamSpecialtyInfoWaterQualityMonitoringStation>
    {
        public void Configure(EntityTypeBuilder<WasteDamSpecialtyInfoWaterQualityMonitoringStation> builder)
        {
            builder.HasOne(q => q.WasteDamSpecialtyInfo).WithMany(y => y.WaterQualityMonitoringStations).HasForeignKey(q => q.WasteDamSpecialtyInfoId);
            builder.HasOne(q => q.WaterQualityMonitoringStation).WithMany().HasForeignKey(q => q.WaterQualityMonitoringStationId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
