using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class SoundAndWavesParametersResultsConfiguration : IEntityTypeConfiguration<SoundAndWavesParametersResults>
   {
      public void Configure(EntityTypeBuilder<SoundAndWavesParametersResults> builder)
      {
         builder.HasOne(q => q.ParametersSamplingResults).WithMany(q => q.SoundAndWavesParametersResults).HasForeignKey(q => q.ParametersSamplingResultsId);
         builder.HasIndex(q => q.Quantity);
         builder.Property(q => q.Operator).HasDefaultValue(OperatorTypes.Equal);
         builder.Property(q => q.Status).HasDefaultValue(ParamPollutionStatuses.Normal);
      }
   }
}
