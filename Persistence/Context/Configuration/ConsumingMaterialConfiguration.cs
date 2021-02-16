using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class ConsumingMaterialConfiguration : IEntityTypeConfiguration<ConsumingMaterial>
   {
      public void Configure(EntityTypeBuilder<ConsumingMaterial> builder)
      {
         builder.Property(p => p.Name).IsRequired().HasMaxLength(255);
         builder.HasOne(p => p.IsicCode10).WithMany().HasForeignKey(f => f.IsicCode10Id).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.HsCode).WithMany().HasForeignKey(f => f.HsCodeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.DapProduction).WithMany().HasForeignKey(f => f.DapProductionId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.MapProduction).WithMany().HasForeignKey(f => f.MapProductionId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.YapProduction).WithMany().HasForeignKey(f => f.YapProductionId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.Industry).WithMany(f => f.ConsumingMaterials);
      }
   }
}
