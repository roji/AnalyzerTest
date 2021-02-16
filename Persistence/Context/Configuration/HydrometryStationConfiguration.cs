using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class HydrometryStationConfiguration : IEntityTypeConfiguration<HydrometryStation>
   {
      public void Configure(EntityTypeBuilder<HydrometryStation> builder)
      {
         builder.OwnsOne(p => p.StationAddress, co =>
         {
            co.HasOne(q => q.Province).WithMany().HasForeignKey(f => f.ProvinceId).OnDelete(DeleteBehavior.Restrict);
            co.HasOne(q => q.State).WithMany().HasForeignKey(f => f.StateId).OnDelete(DeleteBehavior.Restrict);
            co.HasOne(q => q.City).WithMany().HasForeignKey(f => f.CityId).OnDelete(DeleteBehavior.Restrict);
            co.ToTable("HydrometryStation_Addresses");
         });

         builder.Property(p => p.Name).IsRequired();
         builder.Property(p => p.Name).HasMaxLength(255);

         builder.HasOne(p => p.MainBasin).WithMany().HasForeignKey(f => f.MainBasinId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.SecondaryBasin).WithMany().HasForeignKey(f => f.SecondaryBasinId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.RiverRange).WithMany().HasForeignKey(f => f.RiverRangeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.HydrometryStationType).WithMany().HasForeignKey(f => f.HydrometryStationTypeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.HydrometryBuilderCompany).WithMany().HasForeignKey(f => f.HydrometryBuilderCompanyId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.HydrometryEquipmentType).WithMany().HasForeignKey(f => f.HydrometryEquipmentTypeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.GraphType).WithMany().HasForeignKey(f => f.GraphTypeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.DataLoggerCompany).WithMany().HasForeignKey(f => f.DataLoggerCompanyId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.River).WithMany().HasForeignKey(q => q.RiverId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(p => p.ClosedYears).WithOne(p => p.HydrometryStation).HasForeignKey(f => f.HydrometryStationId);
         builder.HasMany(p => p.Monitorings).WithOne(p => p.HydrometryStation).HasForeignKey(f => f.HydrometryStationId);
      }
   }
}
