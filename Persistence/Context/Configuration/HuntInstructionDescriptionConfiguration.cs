using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class HuntInstructionDescriptionConfiguration : IEntityTypeConfiguration<HuntInstructionDescription>
   {
      public void Configure(EntityTypeBuilder<HuntInstructionDescription> builder)
      {
         builder.HasOne(q => q.HuntInstruction).WithMany(q => q.Descriptions).HasForeignKey(q => q.HuntInstructionId);
         builder.HasOne(q => q.User).WithMany().HasForeignKey(q => q.UserId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
