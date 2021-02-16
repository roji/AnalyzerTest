
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class IndustrialUnitsSamplingResultConfiguration : IEntityTypeConfiguration<IndustrialUnitsSamplingResult>
   {
      public void Configure(EntityTypeBuilder<IndustrialUnitsSamplingResult> builder)
      {
         builder.HasOne(q => q.Lab).WithMany(w => w.IndustrialUnitsSamplingResults).HasForeignKey(f => f.LabId).OnDelete(DeleteBehavior.Restrict).IsRequired();
         builder.HasOne(p => p.LabPartner).WithMany().HasForeignKey(f => f.LabPartnerId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.LabManagerVerifier).WithMany().HasForeignKey(f => f.LabManagerVerifierId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.MonitoringPeriod).WithMany().HasForeignKey(f => f.MonitoringPeriodId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(p => p.ParametersSamplingResults).WithOne(p => p.IndustrialUnitsSamplingResult).HasForeignKey(k => k.IndustrialUnitsSamplingResultId);
         builder.HasMany(p => p.ExperimentParametersClassifications).WithOne(p => p.IndustrialUnitsSamplingResult).HasForeignKey(k => k.IndustrialUnitsSamplingResultId);
         builder.HasOne(p => p.Industry).WithMany().HasForeignKey(f => f.IndustryId).OnDelete(DeleteBehavior.Restrict);
         builder.HasIndex(q => q.FinalSave);
         builder.HasOne(q => q.ApproveSamplingExpert).WithMany().HasForeignKey(q => q.ApproveSamplingExpertId).OnDelete(DeleteBehavior.Restrict);
         builder.Property(q => q.IsMonitoringDone).HasDefaultValue(false);
      }
   }
}
