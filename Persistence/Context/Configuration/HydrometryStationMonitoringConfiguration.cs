
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class HydrometryStationMonitoringConfiguration : IEntityTypeConfiguration<HydrometryStationMonitoring>
    {
        public void Configure(EntityTypeBuilder<HydrometryStationMonitoring> builder)
        {
            builder.HasOne(p => p.MonitoringParameter).WithMany().HasForeignKey(f => f.MonitoringParameterId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.MonitoringFrequency).WithMany().HasForeignKey(f => f.MonitoringFrequencyId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.HydrometryStation).WithMany(y => y.Monitorings).HasForeignKey(q => q.HydrometryStationId);
        }
    }
}
