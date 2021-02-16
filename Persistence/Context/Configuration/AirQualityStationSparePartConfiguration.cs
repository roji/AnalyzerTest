
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class AirQualityStationSparePartConfiguration : IEntityTypeConfiguration<AirQualityStationSparePart>
    {
        public void Configure(EntityTypeBuilder<AirQualityStationSparePart> builder)
        {
            builder.HasOne(q => q.AirQualityStationParametersAnalyzer).WithMany(y => y.AirQualityStationSpareParts).HasForeignKey(q => q.AirQualityStationParametersAnalyzerId);
            builder.HasOne(p => p.StationSparePart).WithMany().HasForeignKey(f => f.StationSparePartId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
