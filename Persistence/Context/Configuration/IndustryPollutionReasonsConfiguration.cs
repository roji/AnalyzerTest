
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class IndustryPollutionReasonsConfiguration : IEntityTypeConfiguration<IndustryPollutionReasons>
    {
        public void Configure(EntityTypeBuilder<IndustryPollutionReasons> builder)
        {
            builder.HasOne(p => p.IndustrialUnitsSamplingResult);
            builder.HasOne(p => p.IndustryInspection);
            builder.HasOne(p => p.IndustryWarning);
            builder.HasOne(p => p.IndustryPollution).WithMany(f => f.PollutionReasons).HasForeignKey(q => q.IndustryPollutionId);
        }
    }
}
