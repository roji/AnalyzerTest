using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class MineralStoneMuseumConfiguration : IEntityTypeConfiguration<MineralStoneMuseum>
   {
      public void Configure(EntityTypeBuilder<MineralStoneMuseum> builder)
      {
         builder.Property(p => p.Name).HasMaxLength(255);
         builder.HasOne(p => p.LocationAccuracy).WithMany().HasForeignKey(f => f.LocationAccuracyId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.MineralStoneHardness).WithMany().HasForeignKey(f => f.MineralStoneHardnessId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.MineralStoneStoneType).WithMany().HasForeignKey(f => f.MineralStoneStoneTypeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.MineralStoneMineralType).WithMany().HasForeignKey(f => f.MineralStoneMineralTypeId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.MineralStoneLocation).WithMany().HasForeignKey(f => f.MineralStoneLocationId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.MineralStoneProtectedZone).WithMany().HasForeignKey(f => f.MineralStoneProtectedZoneId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.MineralStoneCrystallizationSystem).WithMany().HasForeignKey(f => f.MineralStoneCrystallizationSystemId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.Province).WithMany().HasForeignKey(f => f.ProvinceId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
