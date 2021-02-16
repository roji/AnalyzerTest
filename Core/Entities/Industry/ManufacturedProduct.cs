using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;
using Core.Entities.AuditableEntity;
using static Core.Entities.Industry;

namespace Core.Entities
{
   public class ManufacturedProduct : IAuditableEntity, IAccessControl
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public string ProductionMethod { get; set; }
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
      public string ProductionLineIntroduction { get; set; }
      public virtual Upload ScannerBlockDiagramFileName { get; set; }

      [StringLength(38)]
      public string ScannerBlockDiagramFileNameId { get; set; }
      public int IndustryId { get; set; }
      public virtual Industry Industry { get; set; }
      public ProductKeepingMethods? KeepingMethod { get; set; }
   }
}
