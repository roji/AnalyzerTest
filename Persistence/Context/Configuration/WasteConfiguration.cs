using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class WasteConfiguration : IEntityTypeConfiguration<Waste>
   {
      public void Configure(EntityTypeBuilder<Waste> builder)
      {
         builder.HasOne(q => q.Repository).WithMany().HasForeignKey(q => q.RepositoryId).OnDelete(DeleteBehavior.Cascade);
         builder.HasOne(q => q.ProduceFrequency).WithMany().HasForeignKey(q => q.ProduceFrequencyId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.ProducedWasteLocation).WithMany().HasForeignKey(q => q.ProducedWasteLocationId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.Industry).WithMany(y => y.Wastes).HasForeignKey(q => q.IndustryId);
         builder.HasOne(q => q.WasteCoding).WithMany(q => q.Wastes).HasForeignKey(y => y.WasteCodingId);
         builder.HasOne(q => q.NormalWasteInformation).WithOne(q => q.Waste);
         builder.HasMany(q => q.KeepingMethods).WithOne(q => q.Waste).HasForeignKey(q => q.WasteId);
         builder.HasMany(q => q.CollectMethods).WithOne(q => q.Waste).HasForeignKey(q => q.WasteId);
         builder.HasMany(q => q.MaterialModes).WithOne(q => q.Waste).HasForeignKey(q => q.WasteId);
         builder.Property(q => q.MeasurementUnit).HasDefaultValue(WasteMeasurementUnits.Kilogram);
      }
   }
}
