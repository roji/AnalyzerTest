using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class IndustryEstablishmentDocumentFileConfiguration : IEntityTypeConfiguration<IndustryEstablishmentDocumentFile>
   {
      public void Configure(EntityTypeBuilder<IndustryEstablishmentDocumentFile> builder)
      {
         builder.HasOne(q => q.IndustryEstablishment).WithMany(q => q.DocumentFiles).HasForeignKey(q => q.IndustryEstablishmentId);
         builder.HasOne(q => q.DocumentType).WithMany().HasForeignKey(q => q.DocumentTypeId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
