using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class HospitalTesterPersonnel : IAuditableEntity
   {
      public int Id { get; set; }
      public int PersonnelId { get; set; }
      public virtual Personnel Personnel { get; set; }
      public int HospitalSamplingResultId { get; set; }
      public virtual HospitalSamplingResult HospitalSamplingResult { get; set; }
      public HospitalPersonnelTypes PersonnelType { get; set; }
   }
   public enum HospitalPersonnelTypes : int
   {
      Testers = 1,
      SamplerExpert = 2,
      TechnicalAssistantVerifier = 3
   }
}
