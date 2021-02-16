using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class IndustryWarningConfiguration : IEntityTypeConfiguration<IndustryWarning>
   {
      public void Configure(EntityTypeBuilder<IndustryWarning> builder)
      {
         builder.HasOne(p => p.GeneralAdministrationOpinion).WithMany().HasForeignKey(f => f.GeneralAdministrationOpinionId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(p => p.WarningReasons).WithOne(p => p.IndustryWarning).HasForeignKey(f => f.IndustryWarningId);
         builder.HasMany(p => p.Descriptions).WithOne(p => p.IndustryWarning).HasForeignKey(f => f.IndustryWarningId);
         builder.HasOne(p => p.Industry).WithMany(f => f.IndustryWarnings).HasForeignKey(q => q.IndustryId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.IndustryInspection).WithMany().HasForeignKey(q => q.IndustryInspectionId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.IndustrialUnitsSamplingResult).WithMany().HasForeignKey(q => q.IndustrialUnitsSamplingResultId).OnDelete(DeleteBehavior.Restrict);
         builder.Property(q => q.Status).HasDefaultValue(IndustryWarningStatuses.IndustryCommitments);
      }
   }
}
