using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class HunterNativeConfiguration : IEntityTypeConfiguration<HunterNative>
   {
      public void Configure(EntityTypeBuilder<HunterNative> builder)
      {
         builder.HasOne(q => q.Province).WithMany().HasForeignKey(f => f.ProvinceId).OnDelete(DeleteBehavior.Restrict);
         builder.Property(q => q.Status).HasDefaultValue(HunterNativeStatuses.ExpertApprove);
         builder.HasOne(q => q.Hunter).WithOne(q => q.Native).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(q => q.Descriptions).WithOne(q => q.HunterNative).HasForeignKey(q => q.HunterNativeId);
      }
   }
}
