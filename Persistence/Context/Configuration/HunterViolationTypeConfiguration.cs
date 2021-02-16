
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class HunterViolationTypeConfiguration : IEntityTypeConfiguration<HunterViolationType>
    {
        public void Configure(EntityTypeBuilder<HunterViolationType> builder)
        {
            builder.HasOne(q => q.HunterViolation).WithMany(y => y.ViolationTypes).HasForeignKey(q => q.HunterViolationId);
            builder.HasOne(p => p.ViolationType).WithMany().HasForeignKey(f => f.ViolationTypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
