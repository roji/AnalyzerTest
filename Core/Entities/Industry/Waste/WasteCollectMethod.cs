namespace Core.Entities
{
   public class WasteCollectMethod
   {
      public int Id { get; set; }
      public int CollectMethodId { get; set; }
      public virtual EnumData CollectMethod { get; set; }
      public int WasteId { get; set; }
      public virtual Waste Waste { get; set; }
   }
}
