
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class LandfillSpecialtyInfoBurialInformationConfiguration : IEntityTypeConfiguration<LandfillSpecialtyInfoBurialInformation>
    {
        public void Configure(EntityTypeBuilder<LandfillSpecialtyInfoBurialInformation> builder)
        {
            builder.HasOne(q => q.LandfillSpecialtyInfo).WithOne(q => q.BurialInformation);
        }
    }
}
