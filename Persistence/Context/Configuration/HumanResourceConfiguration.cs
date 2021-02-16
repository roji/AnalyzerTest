
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class HumanResourceConfiguration : IEntityTypeConfiguration<HumanResource>
    {
        public void Configure(EntityTypeBuilder<HumanResource> builder)
        {
            builder.Property(p => p.PersonnelTotalNumber).IsRequired();

            builder.HasOne(p => p.Industry).WithOne(f => f.HumanResource);
        }
    }
}
