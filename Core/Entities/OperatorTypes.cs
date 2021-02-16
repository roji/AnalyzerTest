using System;
using System.ComponentModel.DataAnnotations;
namespace Core.Entities
{
   public enum OperatorTypes : int
   {
      [Display(Name = "برابر با")] Equal = 1,

      [Display(Name = "بزرگتر از")] GreaterThan = 2,

      [Display(Name = "کمتر از")] LessThan = 3,
   }
}
