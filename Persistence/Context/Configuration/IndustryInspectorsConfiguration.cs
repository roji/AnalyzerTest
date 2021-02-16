
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class IndustryInspectorsConfiguration : IEntityTypeConfiguration<IndustryInspectors>
    {
        public void Configure(EntityTypeBuilder<IndustryInspectors> builder)
        {
            builder.Property(p => p.FullName).IsRequired().HasMaxLength(300);
            builder.Property(p => p.Rank).HasMaxLength(500);
            builder.HasOne(p => p.IndustryInspection).WithMany(f => f.Inspectors).HasForeignKey(q => q.IndustryInspectionId);
        }
    }
}
