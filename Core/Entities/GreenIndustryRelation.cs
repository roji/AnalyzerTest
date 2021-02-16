using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class GreenIndustryRelation : IAuditableEntity
   {
      public int EstablishmentGroupingId { get; set; }
      public int UnderCriteriaId { get; set; }
      public double? Ratio { get; set; }
      public double? ScoreLimitation { get; set; }
      public virtual EnumData EstablishmentGrouping { get; set; }
      public virtual EnumData UnderCriteria { get; set; }
   }
}
