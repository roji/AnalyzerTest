using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class ProductClassificationConfiguration : IEntityTypeConfiguration<ProductClassification>
   {
      public void Configure(EntityTypeBuilder<ProductClassification> builder)
      {
         builder.HasOne(q => q.IsicCode10).WithOne(q => q.ProductClassification).HasForeignKey<ProductClassification>(q => q.IsicCode10Id)
            .OnDelete(DeleteBehavior.Restrict);
         builder.HasIndex(q => q.IsicCode10Id).IsUnique();
      }
   }
}
