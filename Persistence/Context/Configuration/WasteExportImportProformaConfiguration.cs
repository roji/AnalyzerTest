
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class WasteExportImportProformaConfiguration : IEntityTypeConfiguration<WasteExportImportProforma>
    {
        public void Configure(EntityTypeBuilder<WasteExportImportProforma> builder)
        {
            builder.HasOne(q => q.WasteExportImport).WithOne(q => q.Proforma);
        }
    }
}
