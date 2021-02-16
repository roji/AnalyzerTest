using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class AnimalMuseumConfiguration : IEntityTypeConfiguration<AnimalMuseum>
   {
      public void Configure(EntityTypeBuilder<AnimalMuseum> builder)
      {
         builder.Property(p => p.PersianName).HasMaxLength(255);
         builder.Property(p => p.EnglishName).HasMaxLength(255);
         builder.HasOne(p => p.LocationAccuracy).WithMany().HasForeignKey(f => f.LocationAccuracyId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.AnimalPreservation).WithMany().HasForeignKey(f => f.AnimalPreservationId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.AnimalConservationStatus).WithMany().HasForeignKey(f => f.AnimalConservationStatusId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.AnimalEcosystem).WithMany().HasForeignKey(f => f.AnimalEcosystemId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.AnimalType).WithMany().HasForeignKey(f => f.AnimalTypeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.AnimalSubSpecies).WithMany().HasForeignKey(f => f.AnimalSubSpeciesId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.AnimalSpecies).WithMany().HasForeignKey(f => f.AnimalSpeciesId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.AnimalGenus).WithMany().HasForeignKey(f => f.AnimalGenusId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.AnimalFamily).WithMany().HasForeignKey(f => f.AnimalFamilyId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.AnimalOrder).WithMany().HasForeignKey(f => f.AnimalOrderId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.AnimalClass).WithMany().HasForeignKey(f => f.AnimalClassId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.AnimalPhylum).WithMany().HasForeignKey(f => f.AnimalPhylumId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.AnimalKingdom).WithMany().HasForeignKey(f => f.AnimalKingdomId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.AnimalLocation).WithMany().HasForeignKey(f => f.AnimalLocationId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.AnimalProtectedZone).WithMany().HasForeignKey(f => f.AnimalProtectedZoneId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.Province).WithMany().HasForeignKey(f => f.ProvinceId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
