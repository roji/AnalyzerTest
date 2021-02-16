using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class HunterNativeDescriptionConfiguration : IEntityTypeConfiguration<HunterNativeDescription>
   {
      public void Configure(EntityTypeBuilder<HunterNativeDescription> builder)
      {
         builder.HasOne(q => q.HunterNative).WithMany(q => q.Descriptions).HasForeignKey(q => q.HunterNativeId);
         builder.HasOne(q => q.User).WithMany().HasForeignKey(q => q.UserId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
