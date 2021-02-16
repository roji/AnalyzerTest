using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class AltitudeConfiguration : IEntityTypeConfiguration<Altitude>
   {
      public void Configure(EntityTypeBuilder<Altitude> builder)
      {
         builder.Property(q => q.Name).HasMaxLength(350).IsRequired();
         builder.HasOne(q => q.Province).WithMany().HasForeignKey(q => q.ProvinceId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.AltitudeType).WithMany().HasForeignKey(q => q.AltitudeTypeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.Aquifer).WithMany(w => w.Altitudes).HasForeignKey(q => q.AquiferId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(q => q.Aqueducts).WithOne(w => w.Altitude).HasForeignKey(w => w.AltitudeId);
         builder.HasMany(q => q.Pits).WithOne(w => w.Altitude).HasForeignKey(w => w.AltitudeId);
         builder.HasMany(q => q.Fountains).WithOne(w => w.Altitude).HasForeignKey(w => w.AltitudeId);
      }
   }
}
