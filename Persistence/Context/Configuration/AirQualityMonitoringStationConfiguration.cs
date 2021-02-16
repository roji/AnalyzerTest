
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class AirQualityMonitoringStationConfiguration : IEntityTypeConfiguration<AirQualityMonitoringStation>
    {
        public void Configure(EntityTypeBuilder<AirQualityMonitoringStation> builder)
        {
            builder.OwnsOne(p => p.StationAddress, co =>
            {
                co.HasOne(q => q.Province).WithMany().HasForeignKey(f => f.ProvinceId).OnDelete(DeleteBehavior.Restrict);
                co.HasOne(q => q.State).WithMany().HasForeignKey(f => f.StateId).OnDelete(DeleteBehavior.Restrict);
                co.HasOne(q => q.City).WithMany().HasForeignKey(f => f.CityId).OnDelete(DeleteBehavior.Restrict);
                co.ToTable("AirQualityMonitoringStation_Addresses");
            }).OwnsOne(p => p.Manager, (x) => x.ToTable("AirQualityMonitoringStation_Managers"));

            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(255);

            builder.HasOne(p => p.StationType).WithMany().HasForeignKey(f => f.StationTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.StationDataSendingFrequency).WithMany().HasForeignKey(f => f.StationDataSendingFrequencyId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.SatisfactionLevel).WithMany().HasForeignKey(f => f.SatisfactionLevelId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.StationUsageClassification).WithMany().HasForeignKey(f => f.StationUsageClassificationId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.StationModel).WithMany().HasForeignKey(f => f.StationModelId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(p => p.AirQualityStationParametersAnalyzers).WithOne(p => p.AirQualityMonitoringStation).HasForeignKey(f => f.AirQualityMonitoringStationId);
            builder.HasMany(p => p.AirQualityStationMeteorologicalSystems).WithOne(p => p.AirQualityMonitoringStation).HasForeignKey(f => f.AirQualityMonitoringStationId);
        }
    }
}
