
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class MedicalCenterUnitsInfoConfiguration : IEntityTypeConfiguration<MedicalCenterUnitsInfo>
    {
        public void Configure(EntityTypeBuilder<MedicalCenterUnitsInfo> builder)
        {
            builder.HasOne(q => q.MedicalCenterDependencyType).WithMany().HasForeignKey(q => q.MedicalCenterDependencyTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.MedicalCenterActivityType).WithMany().HasForeignKey(q => q.MedicalCenterActivityTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.DisinfectionDeviceStatus).WithMany().HasForeignKey(q => q.DisinfectionDeviceStatusId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.Industry).WithOne(y => y.MedicalCenterUnitsInfo).HasForeignKey<MedicalCenterUnitsInfo>(q => q.IndustryId);
            builder.HasOne(q => q.DisinfectionDevicesInfo).WithOne(y => y.MedicalCenterUnitsInfo);
            builder.HasOne(q => q.MedicalCenterUnitsAdditionalInfo).WithOne(y => y.MedicalCenterUnitsInfo);
        }
    }
}
