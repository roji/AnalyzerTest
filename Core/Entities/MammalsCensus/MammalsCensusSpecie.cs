using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class MammalsCensusSpecie : IAuditableEntity
   {
      public int Id { get; set; }
      public virtual MammalsCensus MammalsCensus { get; set; }
      public int MammalsCensusId { get; set; }
      public int SiteId { get; set; }
      public virtual MammalsSite Site { get; set; }
      public string Hour { get; set; }
      public virtual EnumData Specie { get; set; }
      public int SpecieId { get; set; }
      public int MatureMaleUnderFiveYearsOldQuantity { get; set; }
      public int MatureMaleOverFiveYearsOldQuantity { get; set; }
      public int MatureFemaleQuantity { get; set; }
      public int ImmatureQuantity { get; set; }
      public int UnknownQuantity { get; set; }
   }
}
