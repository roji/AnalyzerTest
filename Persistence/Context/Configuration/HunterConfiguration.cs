using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class HunterConfiguration : IEntityTypeConfiguration<Hunter>
   {
      public void Configure(EntityTypeBuilder<Hunter> builder)
      {

         builder.OwnsOne(p => p.Address, co =>
         {
            co.HasOne(q => q.Province).WithMany().HasForeignKey(f => f.ProvinceId).OnDelete(DeleteBehavior.Restrict);
            co.HasOne(q => q.State).WithMany().HasForeignKey(f => f.StateId).OnDelete(DeleteBehavior.Restrict);
            co.HasOne(q => q.City).WithMany().HasForeignKey(f => f.CityId).OnDelete(DeleteBehavior.Restrict);
            co.ToTable("Hunter_Addresses");
         });

         builder.OwnsOne(p => p.Information, co =>
         {
            co.HasOne(p => p.Religion).WithMany().HasForeignKey(f => f.ReligionId).OnDelete(DeleteBehavior.Restrict);
            co.HasOne(p => p.Grade).WithMany().HasForeignKey(f => f.GradeId).OnDelete(DeleteBehavior.Restrict);
            co.ToTable("Hunter_Information");
         });

         builder.HasMany(p => p.WeaponHistories).WithOne(p => p.Hunter).HasForeignKey(f => f.HunterId);
         builder.HasMany(p => p.ToolsHistories).WithOne(p => p.Hunter).HasForeignKey(f => f.HunterId);
         builder.HasMany(p => p.Violations).WithOne(p => p.Hunter).HasForeignKey(f => f.HunterId);
         builder.HasOne(q => q.Native).WithOne(q => q.Hunter).HasForeignKey<HunterNative>(q => q.HunterId);
         builder.HasMany(p => p.Booklets).WithOne(p => p.Hunter).HasForeignKey(f => f.HunterId);
         builder.HasMany(p => p.HuntingLicenses).WithOne(p => p.Hunter).HasForeignKey(f => f.HunterId);
         builder.HasMany(q => q.InformationValidations).WithOne(x => x.Hunter).HasForeignKey(x => x.HunterId);
         builder.Property(q => q.ValidationScore).HasDefaultValue(0);
         builder.HasOne(q => q.Training).WithOne(q => q.Hunter).HasForeignKey<HunterTraining>(q => q.HunterId);
      }
   }
}
