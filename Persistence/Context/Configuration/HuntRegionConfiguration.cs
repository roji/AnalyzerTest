using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class HuntRegionConfiguration : IEntityTypeConfiguration<HuntRegion>
   {
      public void Configure(EntityTypeBuilder<HuntRegion> builder)
      {
         builder.Property(q => q.Title).IsRequired().HasMaxLength(256);
         builder.HasOne(q => q.Province).WithMany().HasForeignKey(q => q.ProvinceId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
