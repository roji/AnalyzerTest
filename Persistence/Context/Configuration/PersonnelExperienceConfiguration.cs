
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class PersonnelExperienceConfiguration : IEntityTypeConfiguration<PersonnelExperience>
    {
        public void Configure(EntityTypeBuilder<PersonnelExperience> builder)
        {
            builder.HasOne(q => q.Personnel).WithMany(w => w.Experiences).HasForeignKey(f => f.PersonnelId).IsRequired();
            builder.HasOne(p => p.MonitoringType).WithMany().HasForeignKey(f => f.MonitoringTypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
