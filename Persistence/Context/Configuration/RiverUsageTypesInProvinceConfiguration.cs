
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class RiverUsageTypesInProvinceConfiguration : IEntityTypeConfiguration<RiverUsageTypesInProvince>
    {
        public void Configure(EntityTypeBuilder<RiverUsageTypesInProvince> builder)
        {
            builder.HasOne(q => q.RiverProvinceRange).WithMany(y => y.UsageTypesInProvince).HasForeignKey(q => q.RiverProvinceRangeId);
            builder.HasOne(p => p.RiverUsageType).WithMany().HasForeignKey(f => f.RiverUsageTypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
