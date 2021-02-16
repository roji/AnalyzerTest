
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class RiverUsageTypesConfiguration : IEntityTypeConfiguration<RiverUsageTypes>
    {
        public void Configure(EntityTypeBuilder<RiverUsageTypes> builder)
        {
            builder.HasOne(q => q.River).WithMany(y => y.UsageTypes).HasForeignKey(q => q.RiverId);
            builder.HasOne(p => p.RiverUsageType).WithMany().HasForeignKey(f => f.RiverUsageTypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
