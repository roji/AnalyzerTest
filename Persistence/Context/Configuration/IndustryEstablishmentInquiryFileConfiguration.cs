using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class IndustryEstablishmentInquiryFileConfiguration : IEntityTypeConfiguration<IndustryEstablishmentInquiryFile>
   {
      public void Configure(EntityTypeBuilder<IndustryEstablishmentInquiryFile> builder)
      {
         builder.HasOne(q => q.IndustryEstablishment).WithMany(q => q.InquiryFiles).HasForeignKey(q => q.IndustryEstablishmentId);
         builder.HasOne(q => q.InquiryType).WithMany().HasForeignKey(q => q.InquiryTypeId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
