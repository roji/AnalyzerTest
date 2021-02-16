using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class WastewaterParametersResultsConfiguration : IEntityTypeConfiguration<WastewaterParametersResults>
   {
      public void Configure(EntityTypeBuilder<WastewaterParametersResults> builder)
      {
         builder.HasOne(q => q.ParametersSamplingResults).WithMany(q => q.WastewaterParametersResults).HasForeignKey(q => q.ParametersSamplingResultsId);
         builder.HasIndex(q => q.Quantity);
         builder.Property(q => q.Operator).HasDefaultValue(OperatorTypes.Equal);
         builder.Property(q => q.Status).HasDefaultValue(ParamPollutionStatuses.Normal);
         builder.HasOne(w => w.WastewaterType).WithMany().HasForeignKey(x => x.WastewaterTypeId).OnDelete(DeleteBehavior.Restrict);
      }
   }
}
