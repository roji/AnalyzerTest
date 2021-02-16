using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class AqueductWaterUsageConfiguration : IEntityTypeConfiguration<AqueductWaterUsage>
   {
      public void Configure(EntityTypeBuilder<AqueductWaterUsage> builder)
      {
         builder.HasOne(q => q.WaterUsage).WithMany().HasForeignKey(q => q.WaterUsageId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.Aqueduct).WithMany(w => w.WaterUsages).HasForeignKey(w => w.AqueductId);
      }
   }
}
