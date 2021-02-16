
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class ExperimentParametersClassificationConfiguration : IEntityTypeConfiguration<ExperimentParametersClassification>
    {
        public void Configure(EntityTypeBuilder<ExperimentParametersClassification> builder)
        {
            builder.HasOne(q => q.IndustrialUnitsSamplingResult).WithMany(y => y.ExperimentParametersClassifications).HasForeignKey(q => q.IndustrialUnitsSamplingResultId);
            builder.HasOne(p => p.ParamClassification).WithMany().HasForeignKey(f => f.ParamClassificationId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
