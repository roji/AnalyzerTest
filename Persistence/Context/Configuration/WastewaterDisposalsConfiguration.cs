
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class WastewaterDisposalConfiguration : IEntityTypeConfiguration<WastewaterDisposal>
    {
        public void Configure(EntityTypeBuilder<WastewaterDisposal> builder)
        {
            builder.HasOne(p => p.Industry).WithMany(f => f.WastewaterDisposals).HasForeignKey(q => q.IndustryId);
        }
    }
}
