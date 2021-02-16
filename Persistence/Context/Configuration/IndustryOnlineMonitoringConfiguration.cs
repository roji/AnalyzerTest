
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class IndustryOnlineMonitoringConfiguration : IEntityTypeConfiguration<IndustryOnlineMonitoring>
    {
        public void Configure(EntityTypeBuilder<IndustryOnlineMonitoring> builder)
        {
            builder.HasMany(p => p.OnlineMonitoringEquipments).WithOne(p => p.IndustryOnlineMonitoring).HasForeignKey(f => f.IndustryOnlineMonitoringId);
            builder.HasMany(p => p.OnlineMonitoringParameters).WithOne(p => p.IndustryOnlineMonitoring).HasForeignKey(f => f.IndustryOnlineMonitoringId);
            builder.HasOne(p => p.Industry).WithMany(f => f.OnlineMonitorings);
        }
    }
}
