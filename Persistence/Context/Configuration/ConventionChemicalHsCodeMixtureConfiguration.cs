
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class ConventionChemicalHsCodeMixtureConfiguration : IEntityTypeConfiguration<ConventionChemicalHsCodeMixture>
    {
        public void Configure(EntityTypeBuilder<ConventionChemicalHsCodeMixture> builder)
        {
            builder.HasOne(q => q.HsCode).WithMany().HasForeignKey(q => q.HsCodeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.ConventionChemical).WithMany(q => q.HsCodeMixtures).HasForeignKey(q => q.ConventionChemicalId);
        }
    }
}
