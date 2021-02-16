
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class LivestockSpecialtyWasteInformationConfiguration : IEntityTypeConfiguration<LivestockSpecialtyWasteInformation>
    {
        public void Configure(EntityTypeBuilder<LivestockSpecialtyWasteInformation> builder)
        {
            builder.HasOne(q => q.LivestockSpecialtyInfo).WithOne(q => q.WasteInformation);
        }
    }
}
