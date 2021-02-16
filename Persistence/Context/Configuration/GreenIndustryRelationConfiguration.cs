
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Persistence.Context.Configuration
{
    public class GreenIndustryRelationConfiguration : IEntityTypeConfiguration<GreenIndustryRelation>
    {
        public void Configure(EntityTypeBuilder<GreenIndustryRelation> builder)
        {
            builder.HasKey(e => new { e.EstablishmentGroupingId, e.UnderCriteriaId });
            builder.HasIndex(e => e.EstablishmentGroupingId);
            builder.HasIndex(e => e.UnderCriteriaId);
            builder.Property(e => e.EstablishmentGroupingId);
            builder.Property(e => e.UnderCriteriaId);
        }
    }
}