
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class IndustryInspectingPlacesConfiguration : IEntityTypeConfiguration<IndustryInspectingPlaces>
    {
        public void Configure(EntityTypeBuilder<IndustryInspectingPlaces> builder)
        {
            builder.Property(p => p.Place).IsRequired().HasMaxLength(1000);
            builder.HasOne(p => p.IndustryInspection).WithMany(f => f.Places).HasForeignKey(q => q.IndustryInspectionId);
        }
    }
}
