using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class HuntRegionEntranceCertificateOfferingDateConfiguration : IEntityTypeConfiguration<HuntRegionEntranceCertificateOfferingDate>
   {
      public void Configure(EntityTypeBuilder<HuntRegionEntranceCertificateOfferingDate> builder)
      {
         builder.HasOne(x => x.HuntRegionEntranceCertificate).WithMany(x => x.OfferingEntranceDates).HasForeignKey(x => x.HuntRegionEntranceCertificateId);
         builder.Property(x => x.Hour).IsRequired().HasMaxLength(10);
      }
   }
}
