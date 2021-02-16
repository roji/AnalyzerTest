
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class KnowledgeBaseConfiguration : IEntityTypeConfiguration<KnowledgeBase>
    {
        public void Configure(EntityTypeBuilder<KnowledgeBase> builder)
        {
            builder.Property(p => p.Title).IsRequired().HasMaxLength(300);
            builder.HasOne(p => p.KnowledgeBaseGroup).WithMany().HasForeignKey(f => f.KnowledgeBaseGroupId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
