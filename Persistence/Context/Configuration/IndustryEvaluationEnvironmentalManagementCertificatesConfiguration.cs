
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class IndustryEvaluationEnvironmentalManagementCertificatesConfiguration : IEntityTypeConfiguration<IndustryEvaluationEnvironmentalManagementCertificates>
    {
        public void Configure(EntityTypeBuilder<IndustryEvaluationEnvironmentalManagementCertificates> builder)
        {
            builder.Property(p => p.LicenseExporterCompanyName).HasMaxLength(400);
            builder.HasOne(p => p.LicenseType).WithMany().HasForeignKey(f => f.LicenseTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.IndustryEvaluation).WithMany(f => f.EnvironmentalManagementCertificates).HasForeignKey(q => q.IndustryEvaluationId);
        }
    }
}
