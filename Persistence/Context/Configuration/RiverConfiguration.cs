
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class RiverConfiguration : IEntityTypeConfiguration<River>
    {
        public void Configure(EntityTypeBuilder<River> builder)
        {
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(255);

            builder.HasOne(p => p.MainBasin).WithMany().HasForeignKey(f => f.MainBasinId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(p => p.SecondaryBasins).WithOne(p => p.River).HasForeignKey(f => f.RiverId);
            builder.HasMany(p => p.PassingProvinces).WithOne(p => p.River).HasForeignKey(f => f.RiverId);
            builder.HasMany(p => p.UsageTypes).WithOne(p => p.River).HasForeignKey(f => f.RiverId);
            builder.HasMany(p => p.ProvinceRanges).WithOne(p => p.River).HasForeignKey(f => f.RiverId);
        }
    }
}
