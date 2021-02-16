using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class IndustryEstablishmentInspectionVisitorConfiguration : IEntityTypeConfiguration<IndustryEstablishmentInspectionVisitor>
   {
      public void Configure(EntityTypeBuilder<IndustryEstablishmentInspectionVisitor> builder)
      {
         builder.Property(q => q.FullName).HasMaxLength(350).IsRequired();
         builder.HasOne(q => q.IndustryEstablishment).WithMany(q => q.Visitors).HasForeignKey(q => q.IndustryEstablishmentId);
      }
   }
}
