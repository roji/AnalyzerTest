using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class HospitalGuidanceMonitoringConditionConfiguration : IEntityTypeConfiguration<HospitalGuidanceMonitoringCondition>
   {
      public void Configure(EntityTypeBuilder<HospitalGuidanceMonitoringCondition> builder)
      {
         builder.HasOne(q => q.DisinfectionDeviceResult).WithMany(y => y.GuidanceMonitoringConditions).HasForeignKey(q => q.DisinfectionDeviceResultId);
         builder.HasOne(p => p.GuidanceMonitoringCondition).WithMany().HasForeignKey(f => f.GuidanceMonitoringConditionId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
