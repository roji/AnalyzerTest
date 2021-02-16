
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class RiverSecondaryBasinConfiguration : IEntityTypeConfiguration<RiverSecondaryBasin>
    {
        public void Configure(EntityTypeBuilder<RiverSecondaryBasin> builder)
        {
            builder.HasOne(q => q.River).WithMany(y => y.SecondaryBasins).HasForeignKey(q => q.RiverId);
            builder.HasOne(p => p.SecondaryBasin).WithMany().HasForeignKey(f => f.SecondaryBasinId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
