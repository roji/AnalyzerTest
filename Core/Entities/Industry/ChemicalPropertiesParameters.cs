using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class ChemicalPropertiesParameters : IAuditableEntity
    {
        public int Id { get; set; }
        public virtual Wastewater Wastewater { get; set; }
        public int WastewaterId { get; set; }
        public virtual EnumData Ingredient { get; set; }
        public int IngredientId { get; set; }
    }
}
