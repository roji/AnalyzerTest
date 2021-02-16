using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class HuntRegionEntranceCertificateConfiguration : IEntityTypeConfiguration<HuntRegionEntranceCertificate>
   {
      public void Configure(EntityTypeBuilder<HuntRegionEntranceCertificate> builder)
      {
         builder.Property(q => q.Status).HasDefaultValue(HuntRegionEntranceCertificateStatuses.ExpertDateDeterminationReview);
         builder.HasOne(p => p.HuntingLicense).WithMany(w => w.HuntRegionEntranceCertificates).HasForeignKey(f => f.HuntingLicenseId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.EntranceDate).WithMany().HasForeignKey(f => f.EntranceDateId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(p => p.Descriptions).WithOne(p => p.HuntRegionEntranceCertificate).HasForeignKey(f => f.HuntRegionEntranceCertificateId);
         builder.HasMany(p => p.OfferingEntranceDates).WithOne(w => w.HuntRegionEntranceCertificate).HasForeignKey(f => f.HuntRegionEntranceCertificateId);
      }
   }
}
