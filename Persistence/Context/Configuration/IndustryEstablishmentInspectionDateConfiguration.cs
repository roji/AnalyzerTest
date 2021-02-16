using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class IndustryEstablishmentInspectionDateConfiguration : IEntityTypeConfiguration<IndustryEstablishmentInspectionDate>
   {
      public void Configure(EntityTypeBuilder<IndustryEstablishmentInspectionDate> builder)
      {
         builder.HasOne(q => q.IndustryEstablishment).WithMany(q => q.InspectionDates).HasForeignKey(q => q.IndustryEstablishmentId);
         builder.Property(q => q.Hour).HasMaxLength(10);
      }
   }
}
