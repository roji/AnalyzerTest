using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class IndustryWarningDescriptionConfiguration : IEntityTypeConfiguration<IndustryWarningDescription>
   {
      public void Configure(EntityTypeBuilder<IndustryWarningDescription> builder)
      {
         builder.HasOne(q => q.IndustryWarning).WithMany(q => q.Descriptions).HasForeignKey(q => q.IndustryWarningId);
         builder.HasOne(q => q.User).WithMany().HasForeignKey(q => q.UserId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
