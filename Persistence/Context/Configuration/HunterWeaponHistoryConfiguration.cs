
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class HunterWeaponHistoryConfiguration : IEntityTypeConfiguration<HunterWeaponHistory>
    {
        public void Configure(EntityTypeBuilder<HunterWeaponHistory> builder)
        {
            builder.HasOne(p => p.LicenseIssuer).WithMany().HasForeignKey(f => f.LicenseIssuerId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.WeaponType).WithMany().HasForeignKey(f => f.WeaponTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.WeaponModel).WithMany().HasForeignKey(f => f.WeaponModelId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.WeaponCountry).WithMany().HasForeignKey(f => f.WeaponCountryId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.LicenseRegisterProvince).WithMany().HasForeignKey(f => f.LicenseRegisterProvinceId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.LicenseRegisterState).WithMany().HasForeignKey(f => f.LicenseRegisterStateId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.LicenseRegisterCity).WithMany().HasForeignKey(f => f.LicenseRegisterCityId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Hunter).WithMany(q => q.WeaponHistories).HasForeignKey(f => f.HunterId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
