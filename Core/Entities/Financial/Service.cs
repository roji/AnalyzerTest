using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class Service : IAuditableEntity
   {
      public Service()
      {
         OrderItems = new HashSet<OrderItem>();
         IndustryEstablishmentFinancialRelations = new HashSet<IndustryEstablishmentFinancialRelationServices>();
      }
      public int Id { get; set; }
      public string Title { get; set; }
      public virtual EnumData MeasurementUnit { get; set; }
      public int MeasurementUnitId { get; set; }
      public Int64 UnitPrice { get; set; }
      public ServiceTypes Type { get; set; }
      public virtual ICollection<OrderItem> OrderItems { get; set; }
      public virtual ICollection<IndustryEstablishmentFinancialRelationServices> IndustryEstablishmentFinancialRelations { get; set; }
   }
   public enum ServiceTypes : int
   {
      [Display(Name = "عمومی")] Public = 1,

      [Display(Name = "استقرار مرکز")] IndustryEstablishment = 2,

      [Display(Name = "پروانه صید و شکار")] HunterOperation = 3,
   }
}
