using System;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class IndustryMonitoringReferredConfiguration : IEntityTypeConfiguration<IndustryMonitoringReferred>
   {
      public void Configure(EntityTypeBuilder<IndustryMonitoringReferred> builder)
      {
         builder.HasOne(q => q.Reference).WithMany(q => q.Referreds).HasForeignKey(q => q.ReferenceId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.Industry).WithMany(w => w.MonitoringReferreds).HasForeignKey(q => q.IndustryId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.Lab).WithMany(w => w.MonitoringReferreds).HasForeignKey(q => q.LabId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
