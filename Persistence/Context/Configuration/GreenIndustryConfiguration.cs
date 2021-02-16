using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class GreenIndustryConfiguration : IEntityTypeConfiguration<GreenIndustry>
   {
      public void Configure(EntityTypeBuilder<GreenIndustry> builder)
      {
         builder.HasOne(q => q.Industry).WithMany(w => w.GreenIndustries).HasForeignKey(f => f.IndustryId).OnDelete(DeleteBehavior.Restrict).IsRequired();
         builder.HasMany(q => q.Strategies).WithOne(w => w.GreenIndustry);
         builder.HasMany(q => q.Descriptions).WithOne(w => w.GreenIndustry);
      }
   }
}
