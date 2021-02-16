using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class HospitalSamplingResultConfiguration : IEntityTypeConfiguration<HospitalSamplingResult>
   {
      public void Configure(EntityTypeBuilder<HospitalSamplingResult> builder)
      {
         builder.HasOne(q => q.Lab).WithMany(w => w.HospitalSamplingResults).HasForeignKey(f => f.LabId).OnDelete(DeleteBehavior.Restrict).IsRequired();
         builder.HasOne(p => p.LabManagerVerifier).WithMany().HasForeignKey(f => f.LabManagerVerifierId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.MonitoringPeriod).WithMany().HasForeignKey(f => f.MonitoringPeriodId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(p => p.Testers).WithOne(p => p.HospitalSamplingResult).HasForeignKey(k => k.HospitalSamplingResultId);
         builder.HasMany(q => q.DisinfectionDeviceResults).WithOne(w => w.HospitalSamplingResult).HasForeignKey(q => q.HospitalSamplingResultId);
         builder.HasOne(q => q.Industry).WithMany().HasForeignKey(w => w.IndustryId).OnDelete(DeleteBehavior.Restrict).IsRequired();
         builder.HasIndex(q => q.FinalSave);
         builder.HasIndex(q => q.IsDevicesResultsAcceptable);
         builder.Property(q => q.FinalSave).HasDefaultValue(false);
         builder.HasMany(q => q.HospitalUsingFacilities).WithOne(q => q.HospitalSamplingResult).HasForeignKey(w => w.HospitalSamplingResultId);
         builder.Property(q => q.IsMonitoringDone).HasDefaultValue(false);
      }
   }
}
