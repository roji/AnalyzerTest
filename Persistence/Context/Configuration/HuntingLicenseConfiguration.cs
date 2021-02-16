using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class HuntingLicenseConfiguration : IEntityTypeConfiguration<HuntingLicense>
   {
      public void Configure(EntityTypeBuilder<HuntingLicense> builder)
      {
         builder.Property(q => q.Status).HasDefaultValue(HuntingLicenseStatuses.GeneralAdministrationReview);
         builder.HasOne(p => p.Hunter).WithMany(w => w.HuntingLicenses).HasForeignKey(f => f.HunterId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.HuntInstruction).WithMany(w => w.HuntingLicenses).HasForeignKey(f => f.HuntInstructionId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(p => p.Descriptions).WithOne(p => p.HuntingLicense).HasForeignKey(f => f.HuntingLicenseId);
         builder.HasMany(p => p.HuntRegionEntranceCertificates).WithOne(p => p.HuntingLicense).HasForeignKey(p => p.HuntingLicenseId);
      }
   }
}
