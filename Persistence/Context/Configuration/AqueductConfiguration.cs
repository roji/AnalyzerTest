using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class AqueductConfiguration : IEntityTypeConfiguration<Aqueduct>
   {
      public void Configure(EntityTypeBuilder<Aqueduct> builder)
      {
         builder.Property(q => q.Name).HasMaxLength(350).IsRequired();
         builder.HasOne(q => q.Province).WithMany().HasForeignKey(q => q.ProvinceId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.State).WithMany().HasForeignKey(q => q.StateId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.City).WithMany().HasForeignKey(q => q.CityId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.AqueductType).WithMany().HasForeignKey(q => q.AqueductTypeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.AqueductWaterSourceStabilityType).WithMany().HasForeignKey(q => q.AqueductWaterSourceStabilityTypeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.Plain).WithMany(w => w.Aqueducts).HasForeignKey(q => q.PlainId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.Altitude).WithMany(w => w.Aqueducts).HasForeignKey(q => q.AltitudeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(q => q.Wells).WithOne(w => w.Aqueduct).HasForeignKey(q => q.AqueductId);
         builder.HasMany(q => q.WaterUsages).WithOne(w => w.Aqueduct).HasForeignKey(q => q.AqueductId);
      }
   }
}
