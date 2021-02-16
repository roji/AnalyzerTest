using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class HunterBookletConfiguration : IEntityTypeConfiguration<HunterBooklet>
   {
      public void Configure(EntityTypeBuilder<HunterBooklet> builder)
      {
         builder.Property(q => q.Status).HasDefaultValue(HunterBookletStatuses.GeneralOfficeApprove);
         builder.HasOne(q => q.Hunter).WithMany(q => q.Booklets).HasForeignKey(q => q.HunterId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(q => q.Descriptions).WithOne(q => q.HunterBooklet).HasForeignKey(q => q.HunterBookletId);
      }
   }
}
