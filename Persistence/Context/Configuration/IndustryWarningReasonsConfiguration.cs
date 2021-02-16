
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class IndustryWarningReasonsConfiguration : IEntityTypeConfiguration<IndustryWarningReasons>
    {
        public void Configure(EntityTypeBuilder<IndustryWarningReasons> builder)
        {
            builder.HasOne(p => p.IndustrialUnitsSamplingResult);
            builder.HasOne(p => p.IndustryInspection);
            builder.HasOne(p => p.PreviousIndustryWarning);
            builder.HasOne(p => p.IndustryWarning).WithMany(f => f.WarningReasons).HasForeignKey(q => q.IndustryWarningId);
        }
    }
}
