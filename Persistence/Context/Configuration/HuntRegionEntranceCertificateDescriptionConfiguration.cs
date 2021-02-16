using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class HuntRegionEntranceCertificateDescriptionConfiguration : IEntityTypeConfiguration<HuntRegionEntranceCertificateDescription>
   {
      public void Configure(EntityTypeBuilder<HuntRegionEntranceCertificateDescription> builder)
      {
         builder.HasOne(q => q.HuntRegionEntranceCertificate).WithMany(q => q.Descriptions).HasForeignKey(q => q.HuntRegionEntranceCertificateId);
         builder.HasOne(q => q.User).WithMany().HasForeignKey(q => q.UserId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
