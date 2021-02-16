using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class WasteManagementUnitsDetailsConfiguration : IEntityTypeConfiguration<WasteManagementUnitsDetails>
   {
      public void Configure(EntityTypeBuilder<WasteManagementUnitsDetails> builder)
      {
         builder.Property(q => q.MeasurementUnit).HasDefaultValue(WasteMeasurementUnits.Kilogram);
         builder.HasOne(y => y.IsicCode10).WithMany().HasForeignKey(q => q.IsicCode10Id).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(y => y.WasteManagementUnitsInfo).WithMany(h => h.SupportedIsics10).HasForeignKey(y => y.WasteManagementUnitsInfoId);
      }
   }
}
