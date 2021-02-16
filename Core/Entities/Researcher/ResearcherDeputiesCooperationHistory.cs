using System.ComponentModel.DataAnnotations;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class ResearcherDeputiesCooperationHistory : IAuditableEntity
   {
      public int Id { get; set; }
      public ResearcherDeputiesCooperationHistoryTypes Type { get; set; }
      public virtual EnumData Deputy { get; set; }
      public int? DeputyId { get; set; }
      public virtual EnumData Office { get; set; }
      public int? OfficeId { get; set; }
      public string ContractSubject { get; set; }
      public int ContractYear { get; set; }
      public string ContractRelatedIndustryName { get; set; }
      public string Description { get; set; }
      public int ResearcherId { get; set; }
      public virtual Researcher Researcher { get; set; }
   }

   public enum ResearcherDeputiesCooperationHistoryTypes : int
   {
      [Display(Name = "معاونت")] Organization = 1,

      [Display(Name = "نهاد")] Institution = 2
   }
}
