
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class RiverPassingCityConfiguration : IEntityTypeConfiguration<RiverPassingCity>
    {
        public void Configure(EntityTypeBuilder<RiverPassingCity> builder)
        {
            builder.HasOne(q => q.RiverProvinceRange).WithMany(y => y.PassingCities).HasForeignKey(q => q.RiverProvinceRangeId);
            builder.HasOne(p => p.City).WithMany().HasForeignKey(f => f.CityId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
