
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class ServiceAssessmentQuestionnaireConfiguration : IEntityTypeConfiguration<ServiceAssessmentQuestionnaire>
    {
        public void Configure(EntityTypeBuilder<ServiceAssessmentQuestionnaire> builder)
        {
            builder.HasOne(p => p.Grade).WithMany().HasForeignKey(f => f.GradeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Assistance).WithMany().HasForeignKey(f => f.AssistanceId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
