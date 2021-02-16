
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class MedicalCenterSelfDeclarationInfoConfiguration : IEntityTypeConfiguration<MedicalCenterSelfDeclarationInfo>
    {
        public void Configure(EntityTypeBuilder<MedicalCenterSelfDeclarationInfo> builder)
        {
            builder.HasOne(y => y.Industry).WithOne(q => q.MedicalCenterSelfDeclarationInfo).HasForeignKey<MedicalCenterSelfDeclarationInfo>(q => q.IndustryId);
        }
    }
}
