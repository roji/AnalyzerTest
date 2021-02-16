
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class GreenIndustryStrategiesConfiguration : IEntityTypeConfiguration<GreenIndustryStrategies>
    {
        public void Configure(EntityTypeBuilder<GreenIndustryStrategies> builder)
        {
            builder.HasOne(p => p.Criterion).WithMany().HasForeignKey(f => f.CriterionId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.UnderCriteria).WithMany().HasForeignKey(f => f.UnderCriteriaId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Indicator).WithMany().HasForeignKey(f => f.IndicatorId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Strategy).WithMany().HasForeignKey(f => f.StrategyId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.GreenIndustry).WithMany(q => q.Strategies).HasForeignKey(q => q.GreenIndustryId);
            builder.HasIndex(q => q.OrganizationExpertScore);
            builder.HasIndex(q => q.ProvinceExpertScore);
        }
    }
}
