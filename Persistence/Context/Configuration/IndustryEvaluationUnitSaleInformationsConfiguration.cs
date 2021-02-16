
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class IndustryEvaluationUnitSaleInformationsConfiguration : IEntityTypeConfiguration<IndustryEvaluationUnitSaleInformations>
    {
        public void Configure(EntityTypeBuilder<IndustryEvaluationUnitSaleInformations> builder)
        {
            builder.HasOne(p => p.IndustryEvaluation).WithMany(f => f.UnitSaleInformations).HasForeignKey(q => q.IndustryEvaluationId);
        }
    }
}
