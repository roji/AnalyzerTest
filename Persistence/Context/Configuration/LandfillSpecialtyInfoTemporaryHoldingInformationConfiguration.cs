
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class LandfillSpecialtyInfoTemporaryHoldingInformationConfiguration : IEntityTypeConfiguration<LandfillSpecialtyInfoTemporaryHoldingInformation>
    {
        public void Configure(EntityTypeBuilder<LandfillSpecialtyInfoTemporaryHoldingInformation> builder)
        {
            builder.HasOne(q => q.LandfillSpecialtyInfo).WithOne(q => q.TemporaryHoldingInformation);
        }
    }
}
