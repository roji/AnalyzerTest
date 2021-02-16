
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class HunterSeizedDeviceConfiguration : IEntityTypeConfiguration<HunterSeizedDevice>
    {
        public void Configure(EntityTypeBuilder<HunterSeizedDevice> builder)
        {
            builder.HasOne(q => q.HunterViolation).WithMany(y => y.SeizedDevices).HasForeignKey(q => q.HunterViolationId);
            builder.HasOne(p => p.DeviceType).WithMany().HasForeignKey(f => f.DeviceTypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
