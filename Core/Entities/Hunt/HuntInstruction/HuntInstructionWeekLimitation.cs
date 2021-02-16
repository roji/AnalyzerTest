using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class HuntInstructionWeekLimitation : IAuditableEntity
    {
        public int Id { get; set; }
        public virtual EnumData DayInWeek { get; set; }
        public int DayInWeekId { get; set; }
        public virtual HuntInstruction HuntInstruction { get; set; }
        public int HuntInstructionId { get; set; }
    }
}
