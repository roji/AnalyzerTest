using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class WasteParameter : IAuditableEntity
    {
        public int Id { get; set; }
        public int ParamClassificationId { get; set; }
        public virtual EnumData ParamClassification { get; set; }
        public int ParamId { get; set; }
        public virtual EnumData Param { get; set; }
        public int WasteCodingId { get; set; }
        public virtual WasteCoding WasteCoding { get; set; }
    }
}
