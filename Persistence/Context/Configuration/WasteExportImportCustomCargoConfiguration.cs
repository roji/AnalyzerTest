
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class WasteExportImportCustomCargoConfiguration : IEntityTypeConfiguration<WasteExportImportCustomCargo>
    {
        public void Configure(EntityTypeBuilder<WasteExportImportCustomCargo> builder)
        {
            builder.HasOne(p => p.Lab).WithMany().HasForeignKey(f => f.LabId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.WasteExportImport).WithMany(q => q.CustomCargos).HasForeignKey(q => q.WasteExportImportId);
        }
    }
}
