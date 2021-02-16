
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class MedicalCenterUnitsAdditionalInfoConfiguration : IEntityTypeConfiguration<MedicalCenterUnitsAdditionalInfo>
    {
        public void Configure(EntityTypeBuilder<MedicalCenterUnitsAdditionalInfo> builder)
        {
            builder.HasOne(q => q.WasteHoldingMethod).WithMany().HasForeignKey(q => q.WasteHoldingMethodId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.MunicipalityCompanyReceivedTariff).WithMany().HasForeignKey(q => q.MunicipalityCompanyReceivedTariffId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.MedicalWastesReceiver).WithMany().HasForeignKey(q => q.MedicalWastesReceiverId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.MedicalNormalWastesDisposalMethod).WithMany().HasForeignKey(q => q.MedicalNormalWastesDisposalMethodId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.MedicalInfectionWastesDisposalMethod).WithMany().HasForeignKey(q => q.MedicalInfectionWastesDisposalMethodId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.MedicalChemistryWastesDisposalMethod).WithMany().HasForeignKey(q => q.MedicalChemistryWastesDisposalMethodId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.HealthExpertGrade).WithMany().HasForeignKey(q => q.HealthExpertGradeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.MedicalCenterUnitsInfo).WithOne(y => y.MedicalCenterUnitsAdditionalInfo);
        }
    }
}
