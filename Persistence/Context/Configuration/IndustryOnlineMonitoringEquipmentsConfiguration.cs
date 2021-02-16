
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class IndustryOnlineMonitoringEquipmentsConfiguration : IEntityTypeConfiguration<IndustryOnlineMonitoringEquipments>
    {
        public void Configure(EntityTypeBuilder<IndustryOnlineMonitoringEquipments> builder)
        {
            builder.HasOne(p => p.ChimneysInfo);
            builder.HasOne(p => p.OutletWastewater);
            builder.Property(p => p.DeviceModel).HasMaxLength(500);
            builder.Property(p => p.DeviceSellerCompanyName).HasMaxLength(500);
            builder.HasOne(p => p.IndustryOnlineMonitoring).WithMany(f => f.OnlineMonitoringEquipments).HasForeignKey(q => q.IndustryOnlineMonitoringId);
        }
    }
}
