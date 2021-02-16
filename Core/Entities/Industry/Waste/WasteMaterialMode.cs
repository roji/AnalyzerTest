namespace Core.Entities
{
   public class WasteMaterialMode
   {
      public int Id { get; set; }
      public int MaterialModeId { get; set; }
      public virtual EnumData MaterialMode { get; set; }
      public int WasteId { get; set; }
      public virtual Waste Waste { get; set; }
   }
}
