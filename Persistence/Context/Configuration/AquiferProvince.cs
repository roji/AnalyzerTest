using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class AquiferProvinceConfiguration : IEntityTypeConfiguration<AquiferProvince>
   {
      public void Configure(EntityTypeBuilder<AquiferProvince> builder)
      {
         builder.HasOne(q => q.Province).WithMany().HasForeignKey(q => q.ProvinceId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.Aquifer).WithMany(q => q.Provinces).HasForeignKey(q => q.AquiferId);
      }
   }
}
