using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class AccountNumberConfiguration : IEntityTypeConfiguration<AccountNumber>
   {
      public void Configure(EntityTypeBuilder<AccountNumber> builder)
      {
         builder.Property(q => q.Number).IsRequired().HasMaxLength(256);
         builder.Property(q => q.BranchName).IsRequired().HasMaxLength(256);
         builder.Property(q => q.BranchCode).IsRequired().HasMaxLength(50);
         builder.Property(q => q.Shaba).IsRequired().HasMaxLength(26);
         builder.Property(q => q.Card).IsRequired().HasMaxLength(16);
         builder.HasOne(q => q.Province).WithMany().HasForeignKey(q => q.ProvinceId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.Bank).WithMany().HasForeignKey(q => q.BankId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
