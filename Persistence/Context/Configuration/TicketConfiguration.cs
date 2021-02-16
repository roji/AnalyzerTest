
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasOne(p => p.TicketType).WithMany().HasForeignKey(f => f.TicketTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Province).WithMany().HasForeignKey(f => f.ProvinceId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.State).WithMany().HasForeignKey(f => f.StateId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Deputy).WithMany().HasForeignKey(f => f.DeputyId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Office).WithMany().HasForeignKey(f => f.OfficeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.OfficeGroup).WithMany().HasForeignKey(f => f.OfficeGroupId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(q => q.Replies).WithOne(q => q.Ticket).HasForeignKey(w => w.TicketId);
            builder.HasOne(q => q.TicketUser).WithOne(q => q.Ticket);
        }
    }
}
