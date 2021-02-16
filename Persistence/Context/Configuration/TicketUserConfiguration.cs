
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class TicketUserConfiguration : IEntityTypeConfiguration<TicketUser>
    {
        public void Configure(EntityTypeBuilder<TicketUser> builder)
        {
            builder.HasOne(p => p.User).WithMany().HasForeignKey(f => f.UserId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.Ticket).WithOne(q => q.TicketUser);
        }
    }
}
