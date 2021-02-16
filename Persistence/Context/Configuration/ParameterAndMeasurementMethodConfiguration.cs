
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class ParameterAndMeasurementMethodConfiguration : IEntityTypeConfiguration<ParameterAndMeasurementMethod>
    {
        public void Configure(EntityTypeBuilder<ParameterAndMeasurementMethod> builder)
        {
            builder.Property(p => p.StandardExperimentMethod).IsRequired();
            builder.HasOne(q => q.Lab).WithMany(w => w.ParametersAndMeasurementMethods).HasForeignKey(f => f.LabId).IsRequired();
            builder.HasOne(p => p.UsingEquipment).WithMany().HasForeignKey(q => q.UsingEquipmentId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(p => p.Ingredient).WithMany().HasForeignKey(f => f.IngredientId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.IngredientClassification).WithMany().HasForeignKey(f => f.IngredientClassificationId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
