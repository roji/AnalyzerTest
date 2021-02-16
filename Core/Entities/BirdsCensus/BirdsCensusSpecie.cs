using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class BirdsCensusSpecie : IAuditableEntity
   {
      public int Id { get; set; }
      public virtual BirdsCensus BirdsCensus { get; set; }
      public int BirdsCensusId { get; set; }
      public int SiteId { get; set; }
      public virtual BirdsSite Site { get; set; }
      public string Hour { get; set; }
      public virtual EnumData Genus { get; set; }
      public int GenusId { get; set; }
      public virtual EnumData Specie { get; set; }
      public int SpecieId { get; set; }
      public int Quantity { get; set; }
   }
}
