namespace Core.Entities
{
   public class WasteKeepingMethod
   {
      public int Id { get; set; }
      public int KeepingMethodId { get; set; }
      public virtual EnumData KeepingMethod { get; set; }
      public int WasteId { get; set; }
      public virtual Waste Waste { get; set; }
   }
}
