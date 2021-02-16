using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class ParametersSamplingResultsConfiguration : IEntityTypeConfiguration<ParametersSamplingResults>
   {
      public void Configure(EntityTypeBuilder<ParametersSamplingResults> builder)
      {
         builder.HasOne(q => q.MonitoringParameters).WithMany(w => w.ParametersSamplingResults).HasForeignKey(q => q.MonitoringParametersId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.MonitoringType).WithMany().HasForeignKey(f => f.MonitoringTypeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.WasteClassification).WithMany().HasForeignKey(f => f.WasteClassificationId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.WasteName).WithMany().HasForeignKey(f => f.WasteNameId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.FuelType).WithMany().HasForeignKey(f => f.FuelTypeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.PollutionReleaseSource).WithMany().HasForeignKey(f => f.PollutionReleaseSourceId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.AcceptedResource).WithMany().HasForeignKey(f => f.AcceptedResourceId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(q => q.AmbientAirParametersResults).WithOne(q => q.ParametersSamplingResults).HasForeignKey(q => q.ParametersSamplingResultsId);
         builder.HasMany(q => q.WastewaterParametersResults).WithOne(q => q.ParametersSamplingResults).HasForeignKey(q => q.ParametersSamplingResultsId);
         builder.HasMany(q => q.WasteParametersResults).WithOne(q => q.ParametersSamplingResults).HasForeignKey(q => q.ParametersSamplingResultsId);
         builder.HasMany(q => q.SoundAndWavesParametersResults).WithOne(q => q.ParametersSamplingResults).HasForeignKey(q => q.ParametersSamplingResultsId);
         builder.HasMany(q => q.ChimneyParametersResults).WithOne(q => q.ParametersSamplingResults).HasForeignKey(q => q.ParametersSamplingResultsId);
         builder.HasOne(q => q.IndustrialUnitsSamplingResult).WithMany(q => q.ParametersSamplingResults).HasForeignKey(q => q.IndustrialUnitsSamplingResultId);
      }
   }
}
