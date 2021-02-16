
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasMany(q => q.MessageReceivers).WithOne(q => q.Message).HasForeignKey(q => q.MessageId);
            builder.Property(q => q.Id).IsRequired();
            builder.HasIndex(q => q.Id).IsUnique();
            builder.HasIndex(q => q.SentDateTime);
        }
    }
}
