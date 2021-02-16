
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class MunicipalityWasteSpecialtyInfoConfiguration : IEntityTypeConfiguration<MunicipalityWasteSpecialtyInfo>
    {
        public void Configure(EntityTypeBuilder<MunicipalityWasteSpecialtyInfo> builder)
        {
            builder.HasOne(q => q.Industry).WithOne(y => y.MunicipalityWasteSpecialtyInfo).HasForeignKey<MunicipalityWasteSpecialtyInfo>(q => q.IndustryId);
            builder.HasMany(q => q.RelatedIndustries).WithOne(y => y.MunicipalityWasteSpecialtyInfo).HasForeignKey(y => y.MunicipalityWasteSpecialtyInfoId);
        }
    }
}
