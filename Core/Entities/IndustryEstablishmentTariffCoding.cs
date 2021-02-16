using Core.Entities.AuditableEntity;
using Core.Tools;
using static Core.Entities.Industry;
namespace Core.Entities
{
   public class IndustryEstablishmentTariffCoding : IAuditableEntity
   {
      public int Id { get; set; }
      public virtual EnumData ApplicantStatus { get; set; }
      public int ApplicantStatusId { get; set; }
      public IndustryClassifications Classification { get; set; }
      public EstablishmentGroupingTypes EstablishmentGroupingType { get; set; }
      public double Price { get; set; }
      public int Code { get; set; }
   }
}
