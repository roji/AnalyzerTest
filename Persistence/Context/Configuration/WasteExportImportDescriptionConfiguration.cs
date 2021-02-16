
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class WasteExportImportDescriptionsConfiguration : IEntityTypeConfiguration<WasteExportImportDescription>
    {
        public void Configure(EntityTypeBuilder<WasteExportImportDescription> builder)
        {
            builder.HasOne(q => q.WasteExportImport).WithMany(q => q.Descriptions).HasForeignKey(q => q.WasteExportImportId);
            builder.Property(q => q.DescriptionType).HasDefaultValue(WasteExportImportDescriptionTypes.Public);
        }
    }
}
