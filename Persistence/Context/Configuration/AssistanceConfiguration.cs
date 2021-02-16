
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class AssistanceConfiguration : IEntityTypeConfiguration<Assistance>
    {
        public void Configure(EntityTypeBuilder<Assistance> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(255).IsRequired();
            builder.HasOne(p => p.AssistanceClassification).WithMany().HasForeignKey(f => f.AssistanceClassificationId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
