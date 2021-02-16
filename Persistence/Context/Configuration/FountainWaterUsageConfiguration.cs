using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class FountainWaterUsageConfiguration : IEntityTypeConfiguration<FountainWaterUsage>
   {
      public void Configure(EntityTypeBuilder<FountainWaterUsage> builder)
      {
         builder.HasOne(q => q.WaterUsage).WithMany().HasForeignKey(q => q.WaterUsageId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.Fountain).WithMany(w => w.WaterUsages).HasForeignKey(w => w.FountainId);
      }
   }
}
