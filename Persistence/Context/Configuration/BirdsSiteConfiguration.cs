using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class BirdsSiteConfiguration : IEntityTypeConfiguration<BirdsSite>
   {
      public void Configure(EntityTypeBuilder<BirdsSite> builder)
      {
         builder.Property(q => q.PersianName).HasMaxLength(300).IsRequired();
         builder.Property(q => q.EnglishName).HasMaxLength(300);
         builder.HasOne(q => q.Province).WithMany().HasForeignKey(w => w.ProvinceId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.QuadrupleArea).WithMany().HasForeignKey(w => w.QuadrupleAreaId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(q => q.BirdsCensusSpecies).WithOne(w => w.Site).HasForeignKey(w => w.SiteId);
      }
   }
}
