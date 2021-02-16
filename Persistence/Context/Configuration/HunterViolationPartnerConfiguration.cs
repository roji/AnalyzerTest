
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class HunterViolationPartnerConfiguration : IEntityTypeConfiguration<HunterViolationPartner>
    {
        public void Configure(EntityTypeBuilder<HunterViolationPartner> builder)
        {
            builder.HasOne(q => q.HunterViolation).WithMany(y => y.ViolationPartners).HasForeignKey(q => q.HunterViolationId);
        }
    }
}
