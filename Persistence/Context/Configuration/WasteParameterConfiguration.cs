
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class WasteParameterConfiguration : IEntityTypeConfiguration<WasteParameter>
    {
        public void Configure(EntityTypeBuilder<WasteParameter> builder)
        {
            builder.HasOne(p => p.ParamClassification).WithMany().HasForeignKey(f => f.ParamClassificationId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Param).WithMany().HasForeignKey(f => f.ParamId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.WasteCoding).WithMany(q => q.WasteParameters).HasForeignKey(q => q.WasteCodingId);
        }
    }
}
