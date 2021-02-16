using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class IndustryEstablishmentInspectionCoordinateConfiguration : IEntityTypeConfiguration<IndustryEstablishmentInspectionCoordinate>
   {
      public void Configure(EntityTypeBuilder<IndustryEstablishmentInspectionCoordinate> builder)
      {
         builder.HasOne(q => q.IndustryEstablishment).WithMany(q => q.InspectionCoordinates).HasForeignKey(q => q.IndustryEstablishmentId);
         builder.Property(q => q.Latitude).HasMaxLength(50).IsRequired();
         builder.Property(q => q.Longitude).HasMaxLength(50).IsRequired();
      }
   }
}
