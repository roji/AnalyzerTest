using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class LabConfiguration : IEntityTypeConfiguration<Lab>
   {
      public void Configure(EntityTypeBuilder<Lab> builder)
      {
         builder.OwnsOne(p => p.LabAddress, la =>
         {
            la.HasOne(q => q.Province).WithMany().HasForeignKey(f => f.ProvinceId).OnDelete(DeleteBehavior.Restrict);
            la.HasOne(q => q.State).WithMany().HasForeignKey(f => f.StateId).OnDelete(DeleteBehavior.Restrict);
            la.HasOne(q => q.City).WithMany().HasForeignKey(f => f.CityId).OnDelete(DeleteBehavior.Restrict);
            la.ToTable("Lab_Addresses");
         }).OwnsOne(p => p.Manager, (x) =>
         {
            //  x.OwnsOne(m => m.ContactInfo);
            x.ToTable("Lab_Managers");
         });

         builder.Property(p => p.Name).IsRequired();
         builder.Property(p => p.Name).HasMaxLength(255);

         builder.HasOne(p => p.OwnershipStatus).WithMany().HasForeignKey(f => f.OwnershipStatusId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(p => p.Personnels).WithOne(p => p.Lab).HasForeignKey(f => f.LabId);
         builder.HasMany(p => p.Equipments).WithOne(p => p.Lab).HasForeignKey(f => f.LabId);
         builder.HasMany(p => p.ParametersAndMeasurementMethods).WithOne(p => p.Lab).HasForeignKey(f => f.LabId);
         builder.HasMany(p => p.IndustrialUnitsSamplingResults).WithOne(p => p.Lab).HasForeignKey(f => f.LabId);
         builder.HasMany(p => p.LabConsumingMaterials).WithOne(p => p.Lab).HasForeignKey(f => f.LabId);
         builder.HasMany(p => p.HospitalSamplingResults).WithOne(p => p.Lab).HasForeignKey(f => f.LabId);
         builder.HasMany(p => p.MonitoringTypeStartedDates).WithOne(q => q.Lab).HasForeignKey(q => q.LabId);
         builder.HasMany(p => p.Inspections).WithOne(q => q.Lab).HasForeignKey(q => q.LabId);
         builder.HasMany(p => p.Supervisions).WithOne(q => q.Lab).HasForeignKey(q => q.LabId);
         builder.HasMany(p => p.MonitoringReferreds).WithOne(q => q.Lab).HasForeignKey(q => q.LabId);
      }
   }
}
