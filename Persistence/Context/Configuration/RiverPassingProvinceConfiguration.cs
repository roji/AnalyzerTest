
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class RiverPassingProvinceConfiguration : IEntityTypeConfiguration<RiverPassingProvince>
    {
        public void Configure(EntityTypeBuilder<RiverPassingProvince> builder)
        {
            builder.HasOne(q => q.River).WithMany(y => y.PassingProvinces).HasForeignKey(q => q.RiverId);
            builder.HasOne(p => p.Province).WithMany().HasForeignKey(f => f.ProvinceId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
