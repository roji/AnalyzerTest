using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class HospitalDisinfectionDeviceResultConfiguration : IEntityTypeConfiguration<HospitalDisinfectionDeviceResult>
   {
      public void Configure(EntityTypeBuilder<HospitalDisinfectionDeviceResult> builder)
      {
         builder.HasOne(q => q.HospitalSamplingResult).WithMany(w => w.DisinfectionDeviceResults).HasForeignKey(q => q.HospitalSamplingResultId);
         builder.HasMany(p => p.GuidanceMonitoringConditions).WithOne(p => p.DisinfectionDeviceResult).HasForeignKey(k => k.DisinfectionDeviceResultId);
         builder.HasIndex(q => q.IsAcceptable);
      }
   }
}
