using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class WaterQualityMonitoringStationConfiguration : IEntityTypeConfiguration<WaterQualityMonitoringStation>
   {
      public void Configure(EntityTypeBuilder<WaterQualityMonitoringStation> builder)
      {
         builder.OwnsOne(p => p.StationAddress, co =>
         {
            co.HasOne(q => q.Province).WithMany().HasForeignKey(f => f.ProvinceId).OnDelete(DeleteBehavior.Restrict);
            co.HasOne(q => q.State).WithMany().HasForeignKey(f => f.StateId).OnDelete(DeleteBehavior.Restrict);
            co.HasOne(q => q.City).WithMany().HasForeignKey(f => f.CityId).OnDelete(DeleteBehavior.Restrict);
            co.ToTable("WaterQualityMonitoringStation_Addresses");
         });

         builder.Property(p => p.Name).IsRequired();
         builder.Property(p => p.Name).HasMaxLength(255);

         builder.HasOne(p => p.MainBasin).WithMany().HasForeignKey(f => f.MainBasinId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.SecondaryBasin).WithMany().HasForeignKey(f => f.SecondaryBasinId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.RiverRange).WithMany().HasForeignKey(f => f.RiverRangeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.WaterQualityStationType).WithMany().HasForeignKey(f => f.WaterQualityStationTypeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.River).WithMany().HasForeignKey(q => q.RiverId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(p => p.ClosedYears).WithOne(p => p.WaterQualityMonitoringStation).HasForeignKey(f => f.WaterQualityMonitoringStationId);
         builder.HasMany(p => p.Monitorings).WithOne(p => p.WaterQualityMonitoringStation).HasForeignKey(f => f.WaterQualityMonitoringStationId);
         builder.HasMany(p => p.Facilities).WithOne(p => p.WaterQualityMonitoringStation).HasForeignKey(f => f.WaterQualityMonitoringStationId);
         builder.HasMany(p => p.RiverUsages).WithOne(p => p.WaterQualityMonitoringStation).HasForeignKey(f => f.WaterQualityMonitoringStationId);
         builder.HasMany(p => p.SamplingResults).WithOne(p => p.WaterQualityMonitoringStation).HasForeignKey(f => f.WaterQualityMonitoringStationId);
      }
   }
}
