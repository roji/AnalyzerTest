
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class AirQualityStationConsumableConfiguration : IEntityTypeConfiguration<AirQualityStationConsumable>
    {
        public void Configure(EntityTypeBuilder<AirQualityStationConsumable> builder)
        {
            builder.HasOne(q => q.AirQualityStationParametersAnalyzer).WithMany(y => y.AirQualityStationConsumables).HasForeignKey(q => q.AirQualityStationParametersAnalyzerId);
            builder.HasOne(p => p.StationConsumable).WithMany().HasForeignKey(f => f.StationConsumableId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
