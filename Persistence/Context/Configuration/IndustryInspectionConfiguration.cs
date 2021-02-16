using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class IndustryInspectionConfiguration : IEntityTypeConfiguration<IndustryInspection>
   {
      public void Configure(EntityTypeBuilder<IndustryInspection> builder)
      {
         builder.Property(p => p.InspectingHour).HasMaxLength(50);
         builder.HasOne(p => p.InspectReason).WithMany().HasForeignKey(f => f.InspectReasonId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(p => p.Inspectors).WithOne(p => p.IndustryInspection).HasForeignKey(f => f.IndustryInspectionId);
         builder.HasMany(p => p.Places).WithOne(p => p.IndustryInspection).HasForeignKey(f => f.IndustryInspectionId);
         builder.HasMany(p => p.InspectingMonitoringTypes).WithOne(p => p.IndustryInspection).HasForeignKey(f => f.IndustryInspectionId);
         builder.HasOne(p => p.Industry).WithMany(f => f.IndustryInspections).HasForeignKey(q => q.IndustryId).OnDelete(DeleteBehavior.Restrict);;
         builder.HasIndex(q => q.FinalSave);
         builder.Property(q => q.FinalSave).HasDefaultValue(false);
      }
   }
}
