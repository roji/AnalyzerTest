using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class HunterBookletDescriptionConfiguration : IEntityTypeConfiguration<HunterBookletDescription>
   {
      public void Configure(EntityTypeBuilder<HunterBookletDescription> builder)
      {
         builder.HasOne(q => q.HunterBooklet).WithMany(q => q.Descriptions).HasForeignKey(q => q.HunterBookletId);
         builder.HasOne(q => q.User).WithMany().HasForeignKey(q => q.UserId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
