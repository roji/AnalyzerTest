
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class WaterQualityMonitoringStationSamplingResultConfiguration : IEntityTypeConfiguration<WaterQualityMonitoringStationSamplingResult>
    {
        public void Configure(EntityTypeBuilder<WaterQualityMonitoringStationSamplingResult> builder)
        {
            builder.HasIndex(q => q.FinalSave);
            builder.HasOne(p => p.WaterStationSamplingReason).WithMany().HasForeignKey(f => f.WaterStationSamplingReasonId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.WaterYear).WithMany().HasForeignKey(f => f.WaterYearId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.AirAppearance).WithMany().HasForeignKey(f => f.AirAppearanceId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.FlowAppearance).WithMany().HasForeignKey(f => f.FlowAppearanceId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(p => p.SamplingExperts).WithOne(p => p.WaterQualityMonitoringStationSamplingResult).HasForeignKey(f => f.WaterQualityMonitoringStationSamplingResultId);
            builder.HasMany(p => p.SamplingParameters).WithOne(p => p.WaterQualityMonitoringStationSamplingResult).HasForeignKey(f => f.WaterQualityMonitoringStationSamplingResultId);
            builder.HasOne(q => q.WaterQualityMonitoringStation).WithMany(q => q.SamplingResults).HasForeignKey(q => q.WaterQualityMonitoringStationId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
