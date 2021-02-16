using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class IndustryEstablishmentDescriptionConfiguration : IEntityTypeConfiguration<IndustryEstablishmentDescription>
   {
      public void Configure(EntityTypeBuilder<IndustryEstablishmentDescription> builder)
      {
         builder.HasOne(q => q.IndustryEstablishment).WithMany(q => q.Descriptions).HasForeignKey(q => q.IndustryEstablishmentId);
         builder.HasOne(q => q.User).WithMany().HasForeignKey(q => q.UserId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
