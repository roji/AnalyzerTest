
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class WasteExportImportConfiguration : IEntityTypeConfiguration<WasteExportImport>
    {
        public void Configure(EntityTypeBuilder<WasteExportImport> builder)
        {
            builder.HasOne(p => p.WastePackagingType).WithMany().HasForeignKey(f => f.WastePackagingTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.PermittedExportWaste).WithMany().HasForeignKey(f => f.PermittedExportWasteId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.PermittedImportWaste).WithMany().HasForeignKey(f => f.PermittedImportWasteId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Industry).WithMany(q => q.WasteExportImports).HasForeignKey(f => f.IndustryId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(q => q.PassingProvinces).WithOne(w => w.WasteExportImport).HasForeignKey(q => q.WasteExportImportId);
            builder.HasOne(q => q.BorderCustom).WithMany().HasForeignKey(q => q.BorderCustomId);
            builder.HasOne(q => q.InternalTransitCustom).WithMany().HasForeignKey(q => q.InternalTransitCustomId);
            builder.HasMany(q => q.Descriptions).WithOne(w => w.WasteExportImport).HasForeignKey(q => q.WasteExportImportId);
            builder.HasOne(q => q.Representative).WithOne(w => w.WasteExportImport);
            builder.HasOne(q => q.Proforma).WithOne(w => w.WasteExportImport);
        }
    }
}
