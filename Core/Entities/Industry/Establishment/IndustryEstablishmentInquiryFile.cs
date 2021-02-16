using System.ComponentModel.DataAnnotations;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class IndustryEstablishmentInquiryFile : IAuditableEntity
   {
      public int Id { get; set; }
      public virtual EnumData InquiryType { get; set; }
      public int InquiryTypeId { get; set; }
      public virtual Upload InquiryFileName { get; set; }

      [StringLength(38)] public string InquiryFileNameId { get; set; }
      public virtual Upload InquiryAnswerFileName { get; set; }

      [StringLength(38)] public string InquiryAnswerFileNameId { get; set; }
      public int IndustryEstablishmentId { get; set; }
      public virtual IndustryEstablishment IndustryEstablishment { get; set; }
   }
}
