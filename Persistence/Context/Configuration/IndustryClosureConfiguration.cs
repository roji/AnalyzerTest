
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class IndustryClosureConfiguration : IEntityTypeConfiguration<IndustryClosure>
    {
        public void Configure(EntityTypeBuilder<IndustryClosure> builder)
        {
            builder.HasOne(q => q.ClosureReason).WithMany().HasForeignKey(q => q.ClosureReasonId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.Industry).WithMany(y => y.Closures).HasForeignKey(q => q.IndustryId);
        }
    }
}
