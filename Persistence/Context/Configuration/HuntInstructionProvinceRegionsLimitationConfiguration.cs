using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class HuntInstructionProvinceRegionsLimitationConfiguration : IEntityTypeConfiguration<HuntInstructionProvinceRegionsLimitation>
   {
      public void Configure(EntityTypeBuilder<HuntInstructionProvinceRegionsLimitation> builder)
      {
         builder.HasOne(q => q.HuntInstruction).WithMany(y => y.HuntInstructionProvinceRegionsLimitations).HasForeignKey(q => q.HuntInstructionId);
         builder.HasOne(p => p.HuntRegion).WithMany().HasForeignKey(f => f.HuntRegionId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
