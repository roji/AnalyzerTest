
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class LivestockSpecialtyAdditionalInformationConfiguration : IEntityTypeConfiguration<LivestockSpecialtyAdditionalInformation>
    {
        public void Configure(EntityTypeBuilder<LivestockSpecialtyAdditionalInformation> builder)
        {
            builder.HasOne(q => q.LivestockSpecialtyInfo).WithOne(q => q.AdditionalInformation);
            builder.HasOne(q => q.SoilType).WithMany().HasForeignKey(q => q.SoilTypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
