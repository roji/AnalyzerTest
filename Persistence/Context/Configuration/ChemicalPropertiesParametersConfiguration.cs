
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
    public class ChemicalPropertiesParametersConfiguration : IEntityTypeConfiguration<ChemicalPropertiesParameters>
    {
        public void Configure(EntityTypeBuilder<ChemicalPropertiesParameters> builder)
        {
            builder.HasOne(p => p.Wastewater).WithMany(y => y.ChemicalPropertiesParameters).HasForeignKey(f => f.WastewaterId);
            builder.HasOne(p => p.Ingredient).WithMany().HasForeignKey(f => f.IngredientId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
