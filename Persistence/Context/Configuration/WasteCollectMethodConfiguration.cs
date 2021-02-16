using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class WasteCollectMethodConfiguration : IEntityTypeConfiguration<WasteCollectMethod>
   {
      public void Configure(EntityTypeBuilder<WasteCollectMethod> builder)
      {
         builder.HasOne(q => q.Waste).WithMany(y => y.CollectMethods).HasForeignKey(q => q.WasteId);
         builder.HasOne(p => p.CollectMethod).WithMany().HasForeignKey(f => f.CollectMethodId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
