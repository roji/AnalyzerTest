
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class NormalWasteInformationConfiguration : IEntityTypeConfiguration<NormalWasteInformation>
    {
        public void Configure(EntityTypeBuilder<NormalWasteInformation> builder)
        {
            builder.HasOne(q => q.DepotLocationType).WithMany().HasForeignKey(q => q.DepotLocationTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.NormalWasteTransportFrequency).WithMany().HasForeignKey(q => q.NormalWasteTransportFrequencyId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
