
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class WasteExportImportPassingProvinceConfiguration : IEntityTypeConfiguration<WasteExportImportPassingProvince>
    {
        public void Configure(EntityTypeBuilder<WasteExportImportPassingProvince> builder)
        {
            builder.HasOne(p => p.Province).WithMany().HasForeignKey(f => f.ProvinceId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.WasteExportImport).WithMany(q => q.PassingProvinces).HasForeignKey(q => q.WasteExportImportId);
        }
    }
}
