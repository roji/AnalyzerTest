using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class HuntInstructionConfiguration : IEntityTypeConfiguration<HuntInstruction>
   {
      public void Configure(EntityTypeBuilder<HuntInstruction> builder)
      {
         builder.Property(p => p.FromHour).HasMaxLength(10);
         builder.Property(p => p.ToHour).HasMaxLength(10);
         builder.Property(q => q.IssuedNativeLicenseQuantity).HasDefaultValue(0);
         builder.Property(q => q.IssuedForeignLicenseQuantity).HasDefaultValue(0);
         builder.Property(q => q.IssuedNonNativeLicenseQuantity).HasDefaultValue(0);
         builder.Property(q => q.Status).HasDefaultValue(HuntInstructionStatuses.WildLifeOfficeApprove);
         builder.HasOne(p => p.Province).WithMany().HasForeignKey(f => f.ProvinceId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.HuntingType).WithMany().HasForeignKey(f => f.HuntingTypeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.AnimalType).WithMany().HasForeignKey(f => f.AnimalTypeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(p => p.HuntInstructionProvinceRegionsLimitations).WithOne(p => p.HuntInstruction).HasForeignKey(f => f.HuntInstructionId);
         builder.HasMany(p => p.HuntInstructionWeekLimitations).WithOne(p => p.HuntInstruction).HasForeignKey(f => f.HuntInstructionId);
         builder.HasMany(p => p.Descriptions).WithOne(p => p.HuntInstruction).HasForeignKey(f => f.HuntInstructionId);
         builder.HasMany(p => p.HuntingLicenses).WithOne(p => p.HuntInstruction).HasForeignKey(f => f.HuntInstructionId);
      }
   }
}
