
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class HydrometryStationClosedYearConfiguration : IEntityTypeConfiguration<HydrometryStationClosedYear>
    {
        public void Configure(EntityTypeBuilder<HydrometryStationClosedYear> builder)
        {
            builder.HasOne(q => q.HydrometryStation).WithMany(y => y.ClosedYears).HasForeignKey(q => q.HydrometryStationId);
        }
    }
}
