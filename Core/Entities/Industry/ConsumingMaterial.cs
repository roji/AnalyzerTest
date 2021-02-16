using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class ConsumingMaterial : IAuditableEntity, IAccessControl
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public int? DailyAverageProduction { get; set; }
      public int? DapProductionId { get; set; }
      public virtual EnumData DapProduction { get; set; }
      public int? MonthlyAverageProduction { get; set; }
      public int? MapProductionId { get; set; }
      public virtual EnumData MapProduction { get; set; }
      public int? YearlyAverageProduction { get; set; }
      public int? YapProductionId { get; set; }
      public virtual EnumData YapProduction { get; set; }
      public int? IsicCode10Id { get; set; }
      public virtual EnumData IsicCode10 { get; set; }
      public bool HasBeenImported { get; set; }
      public int? HsCodeId { get; set; }
      public virtual EnumData HsCode { get; set; }
      public bool IsChemical { get; set; }
      public int IndustryId { get; set; }
      public virtual Industry Industry { get; set; }
      public string ConventionChemical { get; set; }
      public string ConsumptionDescription { get; set; }
      public ProductKeepingMethods? KeepingMethod { get; set; }
   }
}
