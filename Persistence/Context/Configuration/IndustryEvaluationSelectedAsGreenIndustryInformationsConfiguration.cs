
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class IndustryEvaluationSelectedAsGreenIndustryInformationsConfiguration : IEntityTypeConfiguration<IndustryEvaluationSelectedAsGreenIndustryInformations>
    {
        public void Configure(EntityTypeBuilder<IndustryEvaluationSelectedAsGreenIndustryInformations> builder)
        {
            builder.HasOne(p => p.IndustryEvaluation).WithMany(f => f.SelectedAsGreenIndustryInformations).HasForeignKey(q => q.IndustryEvaluationId);
        }
    }
}
