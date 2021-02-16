
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class ConventionChemicalConfiguration : IEntityTypeConfiguration<ConventionChemical>
    {
        public void Configure(EntityTypeBuilder<ConventionChemical> builder)
        {
            builder.HasOne(q => q.Attachment).WithMany().HasForeignKey(q => q.AttachmentId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.Group).WithMany().HasForeignKey(q => q.GroupId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.HsCode).WithMany().HasForeignKey(q => q.HsCodeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(q => q.HsCodeMixtures).WithOne(q => q.ConventionChemical).HasForeignKey(q => q.ConventionChemicalId);
        }
    }
}
