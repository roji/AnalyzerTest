using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class MonitoringParametersConfiguration : IEntityTypeConfiguration<MonitoringParameters>
   {
      public void Configure(EntityTypeBuilder<MonitoringParameters> builder)
      {
         builder.HasOne(p => p.ParamClassification).WithMany().HasForeignKey(f => f.ParamClassificationId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(p => p.Param).WithMany().HasForeignKey(f => f.ParamId).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(q => q.MonitoringCoding).WithMany(q => q.MonitoringParameters).HasForeignKey(q => q.MonitoringCodingId);
         builder.HasIndex(q => q.PollutionLimitQuantity);
         builder.HasIndex(q => q.LimitAmountQuantity);
         builder.HasMany(q => q.ParametersSamplingResults).WithOne(q => q.MonitoringParameters).HasForeignKey(q => q.MonitoringParametersId);
      }
   }
}
