using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class LabSupervisionConfiguration : IEntityTypeConfiguration<LabSupervision>
   {
      public void Configure(EntityTypeBuilder<LabSupervision> builder)
      {
         builder.HasOne(q => q.Lab).WithMany(w => w.Supervisions).HasForeignKey(f => f.LabId);
         builder.HasOne(q => q.IndustryReferralTimeActivityMethod).WithMany().HasForeignKey(q => q.IndustryReferralTimeActivityMethodId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.IndustrialUnitsSamplingResult).WithMany().HasForeignKey(q => q.IndustrialUnitsSamplingResultId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(q => q.SupervisingExperts).WithOne(q => q.LabSupervision).HasForeignKey(q => q.LabSupervisionId);
         builder.HasIndex(q => q.FinalSave);
         builder.Property(q => q.FinalSave).HasDefaultValue(false);
      }
   }
}
