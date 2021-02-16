using System;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class IndustryMonitoringReferenceConfiguration : IEntityTypeConfiguration<IndustryMonitoringReference>
   {
      public void Configure(EntityTypeBuilder<IndustryMonitoringReference> builder)
      {
         builder.HasOne(q => q.Season).WithMany().HasForeignKey(q => q.SeasonId).OnDelete(DeleteBehavior.Restrict);
         builder.HasMany(q => q.Referreds).WithOne(q => q.Reference).HasForeignKey(q => q.ReferenceId);
      }
   }
}
