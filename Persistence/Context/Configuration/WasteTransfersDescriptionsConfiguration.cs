
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class WasteTransfersDescriptionsConfiguration : IEntityTypeConfiguration<WasteTransfersDescriptions>
    {
        public void Configure(EntityTypeBuilder<WasteTransfersDescriptions> builder)
        {
            builder.HasOne(q => q.WasteTransfer).WithMany(q => q.WasteTransfersDescriptions).HasForeignKey(q => q.WasteTransferId);
            builder.Property(q => q.DescriptionType).HasDefaultValue(WasteTransferDescriptionTypes.Public);
        }
    }
}
