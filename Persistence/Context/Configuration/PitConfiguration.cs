using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class PitConfiguration : IEntityTypeConfiguration<Pit>
   {
      public void Configure(EntityTypeBuilder<Pit> builder)
      {
         builder.Property(q => q.Name).HasMaxLength(350).IsRequired();
         builder.HasOne(q => q.Province).WithMany().HasForeignKey(q => q.ProvinceId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.State).WithMany().HasForeignKey(q => q.StateId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.City).WithMany().HasForeignKey(q => q.CityId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.PitType).WithMany().HasForeignKey(q => q.PitTypeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.PitWaterSourceStabilityType).WithMany().HasForeignKey(q => q.PitWaterSourceStabilityTypeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.Plain).WithMany(w => w.Pits).HasForeignKey(q => q.PlainId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.Altitude).WithMany(w => w.Pits).HasForeignKey(q => q.AltitudeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(q => q.WaterUsages).WithOne(w => w.Pit).HasForeignKey(q => q.PitId);
      }
   }
}
