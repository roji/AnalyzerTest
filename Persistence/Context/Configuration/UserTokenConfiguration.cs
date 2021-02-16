
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Persistence.Context.Configuration
{
    public class UserTokenConfiguration : IEntityTypeConfiguration<UserToken>
    {
        public void Configure(EntityTypeBuilder<UserToken> builder)
        {
            builder.HasOne(ut => ut.User)
                .WithMany(u => u.UserTokens)
                .HasForeignKey(ut => ut.UserId);

            builder.Property(ut => ut.RefreshTokenIdHash).HasMaxLength(450).IsRequired();
            builder.Property(ut => ut.RefreshTokenIdHashSource).HasMaxLength(450);
        }
    }
}