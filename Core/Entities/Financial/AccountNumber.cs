using System.ComponentModel.DataAnnotations;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class AccountNumber : IAuditableEntity
   {
      public int Id { get; set; }
      public string Number { get; set; }
      public string Shaba { get; set; }
      public string Card { get; set; }
      public virtual EnumData Bank { get; set; }
      public int BankId { get; set; }
      public string BranchCode { get; set; }
      public string BranchName { get; set; }
      public virtual EnumData Province { get; set; }
      public int ProvinceId { get; set; }
      public AccountNumberTypes Type { get; set; }
   }
   public enum AccountNumberTypes : int
   {
      [Display(Name = "استقرار مرکز")] IndustryEstablishment = 1,

      [Display(Name = "پروانه صید و شکار")] HunterOperation = 2,
   }
}
