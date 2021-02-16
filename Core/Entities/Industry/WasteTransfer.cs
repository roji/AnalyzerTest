using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;
using Core.Tools;

namespace Core.Entities
{
   public class WasteTransfer : IAuditableEntity, ISoftDeleteEntity, IAccessControl
   {
      public WasteTransfer()
      {
         RelatedProvinces = new List<WasteTransfersRelatedProvinces>();
         WasteTransfersAdditionalIndustries = new List<WasteTransfersAdditionalIndustries>();
         WastesShipments = new List<WastesShipments>();
         WasteTransfersDescriptions = new List<WasteTransfersDescriptions>();
      }
      public int Id { get; set; }
      public int WasteId { get; set; }
      public virtual Waste Waste { get; set; }
      public double Quantity { get; set; }
      public int SenderIndustryId { get; set; }
      public virtual Industry SenderIndustry { get; set; }
      public int RecieverIndustryId { get; set; }
      public virtual Industry RecieverIndustry { get; set; }
      public DateTimeOffset TransferRequestDate { get; set; }
      public virtual Upload WasteAnalysisFileName { get; set; }

      [StringLength(38)]
      public string WasteAnalysisFileNameId { get; set; }
      public virtual EnumData WasteTransferPeriod { get; set; }
      public int? WasteTransferPeriodId { get; set; }
      public string TransportationVehicle { get; set; }
      public virtual ICollection<WasteTransfersRelatedProvinces> RelatedProvinces { get; set; }
      public virtual ICollection<WasteTransfersAdditionalIndustries> WasteTransfersAdditionalIndustries { get; set; }
      public virtual Upload WasteAnalysisResultFileName { get; set; }

      [StringLength(38)]
      public string WasteAnalysisResultFileNameId { get; set; }
      public int? PostDeadlineDate { get; set; }
      public virtual WasteTransferStatuses WasteTransferStatus { get; set; }
      public virtual ICollection<WastesShipments> WastesShipments { get; set; }
      public virtual ICollection<WasteTransfersDescriptions> WasteTransfersDescriptions { get; set; }
      public virtual Lab Lab { get; set; }
      public int? LabId { get; set; }
      public string LicenseNumber { get; set; }
      public int? OriginApprovingDuration { get; set; }
      public int? DestinationApprovingDuration { get; set; }
      public static Expression<Func<WasteTransfer, bool>> GetEntityLimitation(IUserAccessInfoService uai)
      {
         return q =>
            (uai.UserClaims.Intersect(new string[]
            {
               "god",
               "IndustryWasteTransferOriginStateOfficeBossApprove",
               "IndustryWasteTransferOriginInChargeExpertApprove",
               "IndustryWasteTransferOriginHumanEnvironmentDepartmentApprove",
               "IndustryWasteTransferOriginTechnicalAssistantApprove",
               "IndustryWasteTransferOriginGeneralManagerApprove",
               "IndustryWasteTransferDestinationStateOfficeBossApprove",
               "IndustryWasteTransferDestinationInChargeExpertApprove",
               "IndustryWasteTransferDestinationHumanEnvironmentDepartmentApprove",
               "IndustryWasteTransferDestinationTechnicalAssistantApprove",
               "IndustryWasteTransferDestinationGeneralManagerApprove",
            }).Any()) &&
            (uai.UserDataClaims._Skip_wastetransfer ||
               (uai.UserDataClaims.Wastetransfer_receiver_province.Contains(q.RecieverIndustry.WorkshopAddress.ProvinceId)) ||
               (uai.UserDataClaims.Wastetransfer_sender_province.Contains(q.SenderIndustry.WorkshopAddress.ProvinceId)) ||
               (uai.UserDataClaims.Wastetransfer_receiver_state.Contains(q.RecieverIndustry.WorkshopAddress.StateId)) ||
               (uai.UserDataClaims.Wastetransfer_sender_state.Contains(q.SenderIndustry.WorkshopAddress.StateId)));
      }
      public static Expression<Func<WasteTransfer, bool>> GetSmartLimitations(IUserAccessInfoService uai)
      {
         var myLimits = GetEntityLimitation(uai);
         var industryLimit = Industry.GetEntityLimitation(uai);
         var labLimit = Lab.GetEntityLimitation(uai);

         var result = myLimits.Combine(CombineModes.Or, industryLimit, q => q.SenderIndustry)
            .Combine(CombineModes.Or, industryLimit, q => q.RecieverIndustry)
            .Combine(CombineModes.Or, labLimit, q => q.Lab);
         return result;
      }
   }

   public enum WasteTransferStatuses : int
   {
      [Display(Name = "مخالفت توسط کارشناس")] DisagreementByExpert = -3,
      [Display(Name = "مخالفت با درخواست توسط دریافت کننده")] DisagreementByReceiver = -2,
      [Display(Name = "لغو درخواست توسط ارسال کننده")] CanceledBySender = -1,
      [Display(Name = "در انتظار تایید رئیس اداره شهرستان مبدا")] WaitingForOriginStateOfficeBossApprove = 0,
      [Display(Name = "در انتظار تایید کارشناس مسئول پسماند مبدا")] WaitingForOriginInChargeExpertApprove = 1,
      [Display(Name = "در انتظار تایید رئیس اداره محیط انسانی مبدا")] WaitingForOriginHumanEnvironmentDepartmentApprove = 2,
      [Display(Name = "در انتظار تایید معاون فنی مبدا")] WaitingForOriginTechnicalAssistantApprove = 3,
      [Display(Name = "در انتظار تایید مدیر کل مبدا")] WaitingForOriginGeneralManagerApprove = 4,
      [Display(Name = "در انتظار تایید دریافت کننده")] WaitingForReceiverApprove = 5,
      [Display(Name = "در انتظار تایید رئیس اداره شهرستان مقصد")] WaitingForDestinationStateOfficeBossApprove = 6,
      [Display(Name = "در انتظار تایید کارشناس مسئول پسماند مقصد")] WaitingForDestinationInChargeExpertApprove = 7,
      [Display(Name = "در انتظار تایید رئیس اداره محیط انسانی مقصد")] WaitingForDestinationHumanEnvironmentDepartmentApprove = 8,
      [Display(Name = "در انتظار تایید معاون فنی مقصد")] WaitingForDestinationTechnicalAssistantApprove = 9,
      [Display(Name = "در انتظار تایید مدیر کل مقصد")] WaitingForDestinationGeneralManagerApprove = 10,
      [Display(Name = "در انتظار ارسال")] WaitingForSend = 11,
      [Display(Name = "در انتظار دریافت")] WaitingForReceive = 12,
      [Display(Name = "انتقال یافته")] Transfered = 13,
      [Display(Name = "در انتظار آنالیز پسماند")] WaitingForLabAnalyse = 14,
      [Display(Name = "اتمام زمان مجوز بدون بارگیری")] TransferedWithoutShipment = 15,
      [Display(Name = "در انتظار انتخاب آز معتمد توسط ارسال کننده")] WaitingForLabSelection = 16,
   }
}
