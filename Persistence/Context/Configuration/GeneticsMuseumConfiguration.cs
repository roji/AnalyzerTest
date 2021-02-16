using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class GeneticsMuseumConfiguration : IEntityTypeConfiguration<GeneticsMuseum>
   {
      public void Configure(EntityTypeBuilder<GeneticsMuseum> builder)
      {
         builder.Property(p => p.PlantPersianName).HasMaxLength(255);
         builder.Property(p => p.AnimalPersianName).HasMaxLength(255);
         builder.HasOne(p => p.LocationAccuracy).WithMany().HasForeignKey(f => f.LocationAccuracyId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.GeneticsQuality).WithMany().HasForeignKey(f => f.GeneticsQualityId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.GeneticsSpecimenType).WithMany().HasForeignKey(f => f.GeneticsSpecimenTypeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.GeneticsConservationStatus).WithMany().HasForeignKey(f => f.GeneticsConservationStatusId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.GeneticsVariety).WithMany().HasForeignKey(f => f.GeneticsVarietyId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.GeneticsType).WithMany().HasForeignKey(f => f.GeneticsTypeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.GeneticsSubSpecies).WithMany().HasForeignKey(f => f.GeneticsSubSpeciesId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.GeneticsSpecies).WithMany().HasForeignKey(f => f.GeneticsSpeciesId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.GeneticsGenus).WithMany().HasForeignKey(f => f.GeneticsGenusId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.GeneticsFamily).WithMany().HasForeignKey(f => f.GeneticsFamilyId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.GeneticsOrder).WithMany().HasForeignKey(f => f.GeneticsOrderId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.GeneticsClass).WithMany().HasForeignKey(f => f.GeneticsClassId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.GeneticsPhylum).WithMany().HasForeignKey(f => f.GeneticsPhylumId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.GeneticsKingdom).WithMany().HasForeignKey(f => f.GeneticsKingdomId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.GeneticsLocation).WithMany().HasForeignKey(f => f.GeneticsLocationId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.GeneticsProtectedZone).WithMany().HasForeignKey(f => f.GeneticsProtectedZoneId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.Province).WithMany().HasForeignKey(f => f.ProvinceId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
