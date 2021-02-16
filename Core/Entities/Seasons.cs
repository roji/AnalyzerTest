using System.ComponentModel.DataAnnotations;
namespace Core.Entities
{
   // Seasons EnumData Ids
   public enum Seasons : int
   {
      [Display(Name = "فصل بهار")] Spring = 23036,

      [Display(Name = "فصل تابستان")] Summer = 23037,

      [Display(Name = "فصل پاییز")] Autumn = 23038,

      [Display(Name = "فصل زمستان")] Winter = 23039,
   }
}
