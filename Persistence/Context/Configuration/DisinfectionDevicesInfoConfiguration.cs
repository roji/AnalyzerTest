
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class DisinfectionDevicesInfoConfiguration : IEntityTypeConfiguration<DisinfectionDevicesInfo>
    {
        public void Configure(EntityTypeBuilder<DisinfectionDevicesInfo> builder)
        {
            builder.HasOne(y => y.DisinfectionDeviceOwnership).WithMany().HasForeignKey(q => q.DisinfectionDeviceOwnershipId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(y => y.DeviceInActivityCause).WithMany().HasForeignKey(q => q.DeviceInActivityCauseId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(y => y.DisinfectionMethod).WithMany().HasForeignKey(q => q.DisinfectionMethodId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(y => y.AlternativeDisinfectionMethod).WithMany().HasForeignKey(q => q.AlternativeDisinfectionMethodId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(y => y.MedicalCenterUnitsInfo).WithOne(q => q.DisinfectionDevicesInfo);
        }
    }
}
