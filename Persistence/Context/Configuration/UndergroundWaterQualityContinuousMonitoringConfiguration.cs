
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class UndergroundWaterQualityContinuousMonitoringConfiguration : IEntityTypeConfiguration<UndergroundWaterQualityContinuousMonitoring>
    {
        public void Configure(EntityTypeBuilder<UndergroundWaterQualityContinuousMonitoring> builder)
        {
            builder.HasOne(p => p.Lab).WithMany().HasForeignKey(f => f.LabId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Industry).WithMany(q => q.UndergroundWaterQualityContinuousMonitorings).HasForeignKey(f => f.IndustryId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
