using System;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class UserConfiguration : IEntityTypeConfiguration<User>
   {
      public void Configure(EntityTypeBuilder<User> builder)
      {
         builder.Property(e => e.Username).HasMaxLength(450).IsRequired();
         builder.HasIndex(e => e.Username).IsUnique();
         builder.Property(e => e.Email).IsRequired();
         builder.HasIndex(e => e.Email).IsUnique();
         builder.Property(e => e.Mobile).IsRequired();
         builder.HasIndex(e => e.Mobile).IsUnique();
         builder.Property(e => e.Password).IsRequired();
         builder.Property(e => e.SerialNumber).HasMaxLength(450);
         builder.HasOne(e => e.Province).WithMany().HasForeignKey(e => e.ProvinceId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(e => e.State).WithMany().HasForeignKey(e => e.StateId).OnDelete(DeleteBehavior.Restrict);
         builder.Property(q => q.ApiKey).HasDefaultValueSql("UUID()").IsRequired();
         builder.HasIndex(e => e.ApiKey).IsUnique();
         builder.Property(q => q.SecretKeyTemplate).HasDefaultValueSql("SUBSTRING(UUID(), 1, 8)").IsRequired();
         builder.HasIndex(e => e.SecretKeyTemplate).IsUnique();
         builder.Property(q => q.SecretKeyGeneratedDate).HasDefaultValueSql("UTC_TIMESTAMP()");
         builder.Property(q => q.IsForeign).HasDefaultValue(false);
         builder.HasMany(q => q.Invoices).WithOne(q => q.Customer).HasForeignKey(q => q.CustomerId);
      }
   }
}
