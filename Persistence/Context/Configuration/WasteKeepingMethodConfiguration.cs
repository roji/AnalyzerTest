using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class WasteKeepingMethodConfiguration : IEntityTypeConfiguration<WasteKeepingMethod>
   {
      public void Configure(EntityTypeBuilder<WasteKeepingMethod> builder)
      {
         builder.HasOne(q => q.Waste).WithMany(y => y.KeepingMethods).HasForeignKey(q => q.WasteId);
         builder.HasOne(p => p.KeepingMethod).WithMany().HasForeignKey(f => f.KeepingMethodId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
