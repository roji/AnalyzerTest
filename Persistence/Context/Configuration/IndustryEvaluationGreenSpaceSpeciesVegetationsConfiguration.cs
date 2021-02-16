
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class IndustryEvaluationGreenSpaceSpeciesVegetationsConfiguration : IEntityTypeConfiguration<IndustryEvaluationGreenSpaceSpeciesVegetations>
    {
        public void Configure(EntityTypeBuilder<IndustryEvaluationGreenSpaceSpeciesVegetations> builder)
        {
            builder.HasOne(p => p.SpeciesVegetationType).WithMany().HasForeignKey(f => f.SpeciesVegetationTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.IndustryEvaluation).WithMany(f => f.GreenSpaceSpeciesVegetations).HasForeignKey(q => q.IndustryEvaluationId);
        }
    }
}
