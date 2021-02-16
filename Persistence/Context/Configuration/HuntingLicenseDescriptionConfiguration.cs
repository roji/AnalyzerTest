using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class HuntingLicenseDescriptionConfiguration : IEntityTypeConfiguration<HuntingLicenseDescription>
   {
      public void Configure(EntityTypeBuilder<HuntingLicenseDescription> builder)
      {
         builder.HasOne(q => q.HuntingLicense).WithMany(q => q.Descriptions).HasForeignKey(q => q.HuntingLicenseId);
         builder.HasOne(q => q.User).WithMany().HasForeignKey(q => q.UserId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
