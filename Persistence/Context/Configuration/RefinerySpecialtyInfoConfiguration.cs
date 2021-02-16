
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class RefinerySpecialtyInfoConfiguration : IEntityTypeConfiguration<RefinerySpecialtyInfo>
    {
        public void Configure(EntityTypeBuilder<RefinerySpecialtyInfo> builder)
        {
            builder.HasOne(p => p.FlareType).WithMany().HasForeignKey(f => f.FlareTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(p => p.RefinerySendingGasTypes).WithOne(p => p.RefinerySpecialtyInfo).HasForeignKey(f => f.RefinerySpecialtyInfoId);
            builder.HasOne(q => q.Industry).WithOne(y => y.RefinerySpecialtyInfo).HasForeignKey<RefinerySpecialtyInfo>(q => q.IndustryId);
        }
    }
}
