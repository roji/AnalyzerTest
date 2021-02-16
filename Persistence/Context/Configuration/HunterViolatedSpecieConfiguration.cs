
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class HunterViolatedSpecieConfiguration : IEntityTypeConfiguration<HunterViolatedSpecie>
    {
        public void Configure(EntityTypeBuilder<HunterViolatedSpecie> builder)
        {
            builder.HasOne(q => q.HunterViolation).WithMany(y => y.ViolatedSpecies).HasForeignKey(q => q.HunterViolationId);
            builder.HasOne(p => p.Specie).WithMany().HasForeignKey(f => f.SpecieId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.SubSpecie).WithMany().HasForeignKey(f => f.SubSpecieId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
