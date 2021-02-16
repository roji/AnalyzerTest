
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class WasteManagementUnitsInfoConfiguration : IEntityTypeConfiguration<WasteManagementUnitsInfo>
    {
        public void Configure(EntityTypeBuilder<WasteManagementUnitsInfo> builder)
        {
            builder.HasOne(p => p.Industry).WithOne(q => q.WasteManagementUnit).HasForeignKey<WasteManagementUnitsInfo>(f => f.IndustryId);
            builder.HasOne(p => p.WasteManagementUnitClassification).WithMany().HasForeignKey(f => f.WasteManagementUnitClassificationId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(q => q.SupportedIsics10).WithOne(q => q.WasteManagementUnitsInfo).HasForeignKey(q => q.WasteManagementUnitsInfoId);
        }
    }
}
