
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Persistence.Context.Configuration
{
    public class UserTwoStepAuthenticationConfiguration : IEntityTypeConfiguration<UserTwoStepAuthentication>
    {
        public void Configure(EntityTypeBuilder<UserTwoStepAuthentication> builder)
        {
            builder.HasKey(q => q.Id);
            builder.HasOne(ut => ut.User)
                     .WithMany()
                     .HasForeignKey(ut => ut.UserId);
        }
    }
}