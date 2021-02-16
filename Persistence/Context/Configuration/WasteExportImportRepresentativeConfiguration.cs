
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class WasteExportImportRepresentativeConfiguration : IEntityTypeConfiguration<WasteExportImportRepresentative>
    {
        public void Configure(EntityTypeBuilder<WasteExportImportRepresentative> builder)
        {
            builder.HasOne(q => q.WasteExportImport).WithOne(q => q.Representative);
        }
    }
}
