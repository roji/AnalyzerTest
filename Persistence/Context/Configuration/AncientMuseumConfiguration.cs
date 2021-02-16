using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class AncientMuseumConfiguration : IEntityTypeConfiguration<AncientMuseum>
   {
      public void Configure(EntityTypeBuilder<AncientMuseum> builder)
      {
         builder.HasOne(p => p.LocationAccuracy).WithMany().HasForeignKey(f => f.LocationAccuracyId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.AncientAge).WithMany().HasForeignKey(f => f.AncientAgeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.AncientType).WithMany().HasForeignKey(f => f.AncientTypeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.AncientSpecies).WithMany().HasForeignKey(f => f.AncientSpeciesId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.AncientGenus).WithMany().HasForeignKey(f => f.AncientGenusId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.AncientFamily).WithMany().HasForeignKey(f => f.AncientFamilyId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.AncientSubFamily).WithMany().HasForeignKey(f => f.AncientSubFamilyId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.AncientOrder).WithMany().HasForeignKey(f => f.AncientOrderId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.AncientClass).WithMany().HasForeignKey(f => f.AncientClassId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.AncientPhylum).WithMany().HasForeignKey(f => f.AncientPhylumId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.AncientKingdom).WithMany().HasForeignKey(f => f.AncientKingdomId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.AncientLocation).WithMany().HasForeignKey(f => f.AncientLocationId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.AncientProtectedZone).WithMany().HasForeignKey(f => f.AncientProtectedZoneId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.Province).WithMany().HasForeignKey(f => f.ProvinceId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
