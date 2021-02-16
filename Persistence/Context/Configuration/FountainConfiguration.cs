using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class FountainConfiguration : IEntityTypeConfiguration<Fountain>
   {
      public void Configure(EntityTypeBuilder<Fountain> builder)
      {
         builder.Property(q => q.Name).HasMaxLength(350).IsRequired();
         builder.HasOne(q => q.Province).WithMany().HasForeignKey(q => q.ProvinceId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.State).WithMany().HasForeignKey(q => q.StateId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.City).WithMany().HasForeignKey(q => q.CityId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.FountainType).WithMany().HasForeignKey(q => q.FountainTypeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.FountainWaterSourceStabilityType).WithMany().HasForeignKey(q => q.FountainWaterSourceStabilityTypeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.Plain).WithMany(w => w.Fountains).HasForeignKey(q => q.PlainId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.Altitude).WithMany(w => w.Fountains).HasForeignKey(q => q.AltitudeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(q => q.WaterUsages).WithOne(w => w.Fountain).HasForeignKey(q => q.FountainId);
      }
   }
}
