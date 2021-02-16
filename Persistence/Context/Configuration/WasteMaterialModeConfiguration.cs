using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class WasteMaterialModeConfiguration : IEntityTypeConfiguration<WasteMaterialMode>
   {
      public void Configure(EntityTypeBuilder<WasteMaterialMode> builder)
      {
         builder.HasOne(q => q.Waste).WithMany(y => y.MaterialModes).HasForeignKey(q => q.WasteId);
         builder.HasOne(p => p.MaterialMode).WithMany().HasForeignKey(f => f.MaterialModeId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
