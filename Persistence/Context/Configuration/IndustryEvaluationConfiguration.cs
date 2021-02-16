
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class IndustryEvaluationConfiguration : IEntityTypeConfiguration<IndustryEvaluation>
    {
        public void Configure(EntityTypeBuilder<IndustryEvaluation> builder)
        {
            builder.Property(p => p.LicenseNumber).HasMaxLength(50);
            builder.HasOne(p => p.WateringSystemType).WithMany().HasForeignKey(f => f.WateringSystemTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(p => p.GreenSpaceSpeciesVegetations).WithOne(p => p.IndustryEvaluation).HasForeignKey(f => f.IndustryEvaluationId);
            builder.HasMany(p => p.EnvironmentalManagementCertificates).WithOne(p => p.IndustryEvaluation).HasForeignKey(f => f.IndustryEvaluationId);
            builder.HasMany(p => p.UnitSaleInformations).WithOne(p => p.IndustryEvaluation).HasForeignKey(f => f.IndustryEvaluationId);
            builder.HasMany(p => p.SelectedAsGreenIndustryInformations).WithOne(p => p.IndustryEvaluation).HasForeignKey(f => f.IndustryEvaluationId);
            builder.HasOne(p => p.Industry).WithOne(f => f.Evaluation);
        }
    }
}
