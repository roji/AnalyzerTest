
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class MunicipalityWasteSpecialtyAdditionalInfosConfiguration : IEntityTypeConfiguration<MunicipalityWasteSpecialtyAdditionalInfos>
    {
        public void Configure(EntityTypeBuilder<MunicipalityWasteSpecialtyAdditionalInfos> builder)
        {
            builder.HasOne(q => q.MunicipalityWasteSpecialtyInfo).WithMany(y => y.RelatedIndustries).HasForeignKey(q => q.MunicipalityWasteSpecialtyInfoId);
        }
    }
}
