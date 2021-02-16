
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class WasteManagementUnitsConfiguration : IEntityTypeConfiguration<WasteManagementUnitsInfo>
    {
        public void Configure(EntityTypeBuilder<WasteManagementUnitsInfo> builder)
        {
            builder.HasOne(q => q.Industry).WithOne(w => w.WasteManagementUnit);
            builder.HasMany(q => q.SupportedIsics10).WithOne(w => w.WasteManagementUnitsInfo);
            builder.HasOne(q => q.WasteManagementUnitClassification).WithMany().HasForeignKey(q => q.WasteManagementUnitClassificationId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
