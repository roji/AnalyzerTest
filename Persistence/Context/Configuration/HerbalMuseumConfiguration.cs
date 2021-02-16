using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class HerbalMuseumConfiguration : IEntityTypeConfiguration<HerbalMuseum>
   {
      public void Configure(EntityTypeBuilder<HerbalMuseum> builder)
      {
         builder.Property(p => p.PlantName).HasMaxLength(255);
         builder.HasOne(p => p.LocationAccuracy).WithMany().HasForeignKey(f => f.LocationAccuracyId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.HerbalChoroType).WithMany().HasForeignKey(f => f.HerbalChoroTypeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.HerbalConservationStatus).WithMany().HasForeignKey(f => f.HerbalConservationStatusId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.HerbalLifeForm).WithMany().HasForeignKey(f => f.HerbalLifeFormId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.HerbalSoilType).WithMany().HasForeignKey(f => f.HerbalSoilTypeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.HerbalTopography).WithMany().HasForeignKey(f => f.HerbalTopographyId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.HerbalEcosystem).WithMany().HasForeignKey(f => f.HerbalEcosystemId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.HerbalType).WithMany().HasForeignKey(f => f.HerbalTypeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.HerbalVariety).WithMany().HasForeignKey(f => f.HerbalVarietyId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.HerbalSubSpecies).WithMany().HasForeignKey(f => f.HerbalSubSpeciesId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.HerbalSpecies).WithMany().HasForeignKey(f => f.HerbalSpeciesId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.HerbalGenus).WithMany().HasForeignKey(f => f.HerbalGenusId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.HerbalFamily).WithMany().HasForeignKey(f => f.HerbalFamilyId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.HerbalOrder).WithMany().HasForeignKey(f => f.HerbalOrderId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.HerbalClass).WithMany().HasForeignKey(f => f.HerbalClassId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.HerbalPhylum).WithMany().HasForeignKey(f => f.HerbalPhylumId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.HerbalKingdom).WithMany().HasForeignKey(f => f.HerbalKingdomId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.HerbalLocation).WithMany().HasForeignKey(f => f.HerbalLocationId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.HerbalProtectedZone).WithMany().HasForeignKey(f => f.HerbalProtectedZoneId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.Province).WithMany().HasForeignKey(f => f.ProvinceId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
