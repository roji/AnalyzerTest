using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class IndustryConfiguration : IEntityTypeConfiguration<Industry>
   {
      public void Configure(EntityTypeBuilder<Industry> builder)
      {
         builder.OwnsOne(p => p.CentralOfficeAddress, co =>
            {
               co.HasOne(q => q.Province).WithMany().HasForeignKey(f => f.ProvinceId).OnDelete(DeleteBehavior.Restrict);
               co.HasOne(q => q.State).WithMany().HasForeignKey(f => f.StateId).OnDelete(DeleteBehavior.Restrict);
               co.HasOne(q => q.City).WithMany().HasForeignKey(f => f.CityId).OnDelete(DeleteBehavior.Restrict);
               co.ToTable("Industry_OfficeAddresses");
            }).OwnsOne(p => p.WorkshopAddress, wa =>
            {
               wa.HasOne(q => q.Province).WithMany().HasForeignKey(f => f.ProvinceId).OnDelete(DeleteBehavior.Restrict);
               wa.HasOne(q => q.State).WithMany().HasForeignKey(f => f.StateId).OnDelete(DeleteBehavior.Restrict);
               wa.HasOne(q => q.City).WithMany().HasForeignKey(f => f.CityId).OnDelete(DeleteBehavior.Restrict);
               wa.ToTable("Industry_WorkshopAddresses");
            }).OwnsOne(p => p.Manager, (x) => x.ToTable("Industry_Managers"))
            .OwnsOne(p => p.License, q =>
            {
               q.HasOne(p => p.TypeName).WithMany().HasForeignKey(f => f.TypeNameId).OnDelete(DeleteBehavior.Restrict);
               q.ToTable("Industry_License");
            });

         builder.Property(p => p.Name).IsRequired();
         builder.Property(p => p.Name).HasMaxLength(255);
         builder.Property(q => q.IsKnowledgeBased).HasDefaultValue(false);
         builder.HasOne(p => p.IsicCode).WithMany().HasForeignKey(f => f.IsicCodeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.IsicCode10).WithMany().HasForeignKey(f => f.IsicCode10Id).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.EstablishmentGrouping).WithMany().HasForeignKey(f => f.EstablishmentGroupingId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(p => p.Wastes).WithOne(p => p.Industry).HasForeignKey(f => f.IndustryId);
         builder.HasMany(p => p.MonitoringReferreds).WithOne(p => p.Industry).HasForeignKey(f => f.IndustryId);
         builder.HasOne(p => p.WasteManagementUnit).WithOne(p => p.Industry);
         builder.HasMany(p => p.ManufacturedProducts).WithOne(p => p.Industry).HasForeignKey(f => f.IndustryId);
         builder.HasOne(p => p.HumanResource).WithOne(p => p.Industry);
         builder.HasMany(p => p.WaterConsumptions).WithOne(p => p.Industry).HasForeignKey(f => f.IndustryId);
         builder.HasMany(p => p.EnergyConsumptions).WithOne(p => p.Industry).HasForeignKey(f => f.IndustryId);
         builder.HasMany(p => p.RawMaterials).WithOne(p => p.Industry).HasForeignKey(f => f.IndustryId);
         builder.HasMany(p => p.ConsumingMaterials).WithOne(p => p.Industry).HasForeignKey(f => f.IndustryId);
         builder.HasMany(p => p.Wastewaters).WithOne(p => p.Industry).HasForeignKey(f => f.IndustryId);
         builder.HasMany(p => p.WastewaterDisposals).WithOne(p => p.Industry).HasForeignKey(f => f.IndustryId);
         builder.HasMany(p => p.Repositories).WithOne(p => p.Industry).HasForeignKey(f => f.IndustryId);
         builder.HasMany(p => p.IndustryInspections).WithOne(p => p.Industry).HasForeignKey(f => f.IndustryId);
         builder.HasMany(p => p.IndustryPollutions).WithOne(p => p.Industry).HasForeignKey(f => f.IndustryId);
         builder.HasMany(p => p.IndustryWarnings).WithOne(p => p.Industry).HasForeignKey(f => f.IndustryId);
         builder.HasMany(p => p.OnlineMonitorings).WithOne(p => p.Industry).HasForeignKey(f => f.IndustryId);
         builder.HasMany(p => p.GreenIndustries).WithOne(p => p.Industry).HasForeignKey(f => f.IndustryId);
         builder.HasMany(p => p.EnvironmentalHealthExpertReports).WithOne(p => p.Industry).HasForeignKey(f => f.IndustryId);
         builder.HasMany(p => p.UndergroundWaterQualityContinuousMonitorings).WithOne(p => p.Industry).HasForeignKey(f => f.IndustryId);
         builder.HasMany(p => p.EstablishmentRequests).WithOne(p => p.Industry).HasForeignKey(f => f.IndustryId);
         builder.HasMany(p => p.JudicialActions).WithOne(p => p.Industry).HasForeignKey(f => f.IndustryId);
         builder.HasOne(p => p.MonitoringInfo).WithOne(p => p.Industry);
         builder.HasOne(p => p.SlaughterHouseSpecialtyInfo).WithOne(p => p.Industry);
         builder.HasOne(p => p.MedicalCenterSelfDeclarationInfo).WithOne(p => p.Industry);
         builder.HasOne(p => p.MedicalCenterUnitsInfo).WithOne(p => p.Industry);
         builder.HasOne(p => p.IndustrialTownsSpecialtyInfo).WithOne(p => p.Industry);
         builder.HasOne(p => p.LivestockSpecialtyInfo).WithOne(p => p.Industry);
         builder.HasOne(p => p.MunicipalityWasteSpecialtyInfo).WithOne(p => p.Industry);
         builder.HasOne(p => p.Evaluation).WithOne(p => p.Industry);
         builder.HasOne(p => p.LandfillSpecialtyInfo).WithOne(p => p.Industry);
         builder.HasOne(p => p.MineSpecialtyInfo).WithOne(p => p.Industry);
         builder.HasOne(p => p.EstablishmentCase).WithOne(p => p.Industry);
         builder.HasOne(p => p.EstablishmentCaseAdditionalInfo).WithOne(p => p.Industry);
      }
   }
}
