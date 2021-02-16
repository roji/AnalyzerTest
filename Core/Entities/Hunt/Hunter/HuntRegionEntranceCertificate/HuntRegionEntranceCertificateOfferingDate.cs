using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class HuntRegionEntranceCertificateOfferingDate : IAuditableEntity
   {
      public int Id { get; set; }
      public int Date { get; set; }
      public string Hour { get; set; }
      public int HuntRegionEntranceCertificateId { get; set; }
      public virtual HuntRegionEntranceCertificate HuntRegionEntranceCertificate { get; set; }
   }
}
