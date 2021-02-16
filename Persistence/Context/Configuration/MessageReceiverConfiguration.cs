
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class MessageReceiverConfiguration : IEntityTypeConfiguration<MessageReceiver>
    {
        public void Configure(EntityTypeBuilder<MessageReceiver> builder)
        {
            builder.HasOne(q => q.Reciver).WithMany().HasForeignKey(q => q.ReciverId).OnDelete(DeleteBehavior.SetNull);
            builder.HasOne(q => q.Message).WithMany(q => q.MessageReceivers).HasForeignKey(q => q.MessageId).IsRequired().OnDelete(DeleteBehavior.Cascade);
            builder.HasIndex(q => q.SenderStatus);
            builder.HasIndex(q => q.ReceiverStatus);
        }
    }
}
