
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class RiverProvinceRangeConfiguration : IEntityTypeConfiguration<RiverProvinceRange>
    {
        public void Configure(EntityTypeBuilder<RiverProvinceRange> builder)
        {
            builder.HasOne(q => q.River).WithMany(w => w.ProvinceRanges).HasForeignKey(f => f.RiverId).IsRequired();
            builder.HasOne(p => p.Province).WithMany().HasForeignKey(f => f.ProvinceId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(p => p.PassingCities).WithOne(p => p.RiverProvinceRange).HasForeignKey(f => f.RiverProvinceRangeId);
            builder.HasMany(p => p.UsageTypesInProvince).WithOne(p => p.RiverProvinceRange).HasForeignKey(f => f.RiverProvinceRangeId);
        }
    }
}
