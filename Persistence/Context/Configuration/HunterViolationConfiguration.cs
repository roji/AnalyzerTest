
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class HunterViolationConfiguration : IEntityTypeConfiguration<HunterViolation>
    {
        public void Configure(EntityTypeBuilder<HunterViolation> builder)
        {
            builder.HasOne(p => p.ViolatedProvince).WithMany().HasForeignKey(f => f.ViolatedProvinceId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.ViolatedState).WithMany().HasForeignKey(f => f.ViolatedStateId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.ViolatedRegion).WithMany().HasForeignKey(f => f.ViolatedRegionId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.ViolationDegree).WithMany().HasForeignKey(f => f.ViolationDegreeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.RuleStatus).WithMany().HasForeignKey(f => f.RuleStatusId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.DeprivationType).WithMany().HasForeignKey(f => f.DeprivationTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(p => p.ViolatedSpecies).WithOne(p => p.HunterViolation).HasForeignKey(f => f.HunterViolationId);
            builder.HasMany(p => p.ViolationTypes).WithOne(p => p.HunterViolation).HasForeignKey(f => f.HunterViolationId);
            builder.HasMany(p => p.SeizedDevices).WithOne(p => p.HunterViolation).HasForeignKey(f => f.HunterViolationId);
            builder.HasMany(p => p.ViolationPartners).WithOne(p => p.HunterViolation).HasForeignKey(f => f.HunterViolationId);
        }
    }
}
