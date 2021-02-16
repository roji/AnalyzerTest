using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class IndustryEstablishmentConfiguration : IEntityTypeConfiguration<IndustryEstablishment>
   {
      public void Configure(EntityTypeBuilder<IndustryEstablishment> builder)
      {
         builder.HasOne(q => q.Request).WithMany(w => w.Establishments).HasForeignKey(f => f.RequestId);
         builder.HasMany(q => q.Descriptions).WithOne(w => w.IndustryEstablishment).HasForeignKey(q => q.IndustryEstablishmentId);
         builder.HasMany(q => q.DocumentFiles).WithOne(w => w.IndustryEstablishment).HasForeignKey(q => q.IndustryEstablishmentId);
         builder.HasMany(q => q.InspectionCoordinates).WithOne(w => w.IndustryEstablishment).HasForeignKey(q => q.IndustryEstablishmentId);
         builder.HasMany(q => q.InquiryFiles).WithOne(w => w.IndustryEstablishment).HasForeignKey(q => q.IndustryEstablishmentId);
         builder.HasMany(q => q.InspectionDates).WithOne(w => w.IndustryEstablishment).HasForeignKey(q => q.IndustryEstablishmentId);
         builder.HasMany(q => q.Visitors).WithOne(w => w.IndustryEstablishment).HasForeignKey(q => q.IndustryEstablishmentId);
         builder.HasOne(q => q.Expert).WithMany().HasForeignKey(q => q.ExpertId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.InspectionStage).WithMany().HasForeignKey(q => q.InspectionStageId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.SelectedInspectionDate).WithMany().HasForeignKey(q => q.SelectedInspectionDateId).OnDelete(DeleteBehavior.Cascade);
         builder.HasOne(q => q.ApplicantStatus).WithMany().HasForeignKey(q => q.ApplicantStatusId).OnDelete(DeleteBehavior.Restrict);
         builder.Property(p => p.InspectionHour).HasMaxLength(10);
      }
   }
}
