
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class TicketRepliesConfiguration : IEntityTypeConfiguration<TicketReplies>
    {
        public void Configure(EntityTypeBuilder<TicketReplies> builder)
        {
            builder.HasOne(p => p.User).WithMany().HasForeignKey(f => f.UserId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.Ticket).WithMany(q => q.Replies).HasForeignKey(q => q.TicketId);
        }
    }
}
