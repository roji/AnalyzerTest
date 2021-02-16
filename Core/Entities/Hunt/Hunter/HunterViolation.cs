using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class HunterViolation : IAuditableEntity, IAccessControl
   {
      public HunterViolation()
      {
         ViolationTypes = new HashSet<HunterViolationType>();
         ViolatedSpecies = new HashSet<HunterViolatedSpecie>();
         SeizedDevices = new HashSet<HunterSeizedDevice>();
         ViolationPartners = new HashSet<HunterViolationPartner>();
      }
      public int Id { get; set; }
      public int? ViolationObserveDate { get; set; }
      public virtual EnumData ViolatedProvince { get; set; }
      public int? ViolatedProvinceId { get; set; }
      public virtual EnumData ViolatedState { get; set; }
      public int? ViolatedStateId { get; set; }
      public virtual EnumData ViolatedRegion { get; set; }
      public int? ViolatedRegionId { get; set; }
      public int? ViolationStartedDate { get; set; }
      public string CaseNumber { get; set; }
      public virtual EnumData ViolationDegree { get; set; }
      public int? ViolationDegreeId { get; set; }
      public virtual EnumData RuleStatus { get; set; }
      public int? RuleStatusId { get; set; }
      public int? RuleRegisterDate { get; set; }
      public string RuleNumber { get; set; }
      public virtual EnumData DeprivationType { get; set; }
      public int? DeprivationTypeId { get; set; }
      public int? DeprivationDate { get; set; }
      public string DeprivationDescription { get; set; }
      public int? DeprivationFromDate { get; set; }
      public int? DeprivationToDate { get; set; }
      public string DeprivationResult { get; set; }
      public bool? HasJail { get; set; }
      public int? DaysInJail { get; set; }
      public int? MonthsInJail { get; set; }
      public int? YearsInJail { get; set; }
      public bool? HasCashPenalty { get; set; }
      public double? CashPenalty { get; set; }
      public bool? HasOtherPenalty { get; set; }
      public string OtherPenaltyDescription { get; set; }
      public double? RemainedLossingQuantity { get; set; }
      public string RemainedLossingDescription { get; set; }
      public double? PaidLossingQuantity { get; set; }
      public string PaidLossingDescription { get; set; }
      public virtual Upload RuleFileName { get; set; }
      [StringLength(38)]
      public string RuleFileNameId { get; set; }
      public int HunterId { get; set; }
      public virtual Hunter Hunter { get; set; }
      public virtual ICollection<HunterViolationType> ViolationTypes { get; set; }
      public virtual ICollection<HunterViolatedSpecie> ViolatedSpecies { get; set; }
      public virtual ICollection<HunterSeizedDevice> SeizedDevices { get; set; }
      public virtual ICollection<HunterViolationPartner> ViolationPartners { get; set; }
   }
   public enum HunterViolationPartnerTypes : int
   {
      Founder = 1,
      Violator = 2
   }
   public class HunterViolationPartner : IAuditableEntity
   {
      public int Id { get; set; }
      public string FullName { get; set; }
      public string NationalCode { get; set; }
      public string Mobile { get; set; }
      public string Address { get; set; }
      public HunterViolationFounderTypes? FounderType { get; set; }
      public HunterViolationPartnerTypes PartnerType { get; set; }
      public virtual HunterViolation HunterViolation { get; set; }
      public int HunterViolationId { get; set; }
   }
   public class HunterViolationType : IAuditableEntity
   {
      public int Id { get; set; }
      public virtual HunterViolation HunterViolation { get; set; }
      public int HunterViolationId { get; set; }
      public virtual EnumData ViolationType { get; set; }
      public int ViolationTypeId { get; set; }
   }
   public class HunterViolatedSpecie : IAuditableEntity
   {
      public int Id { get; set; }
      public virtual HunterViolation HunterViolation { get; set; }
      public int HunterViolationId { get; set; }
      public virtual EnumData Specie { get; set; }
      public int SpecieId { get; set; }
      public virtual EnumData SubSpecie { get; set; }
      public int SubSpecieId { get; set; }
      public int? Quantity { get; set; }
   }
   public class HunterSeizedDevice : IAuditableEntity
   {
      public int Id { get; set; }
      public virtual HunterViolation HunterViolation { get; set; }
      public int HunterViolationId { get; set; }
      public virtual EnumData DeviceType { get; set; }
      public int DeviceTypeId { get; set; }
      public string DeviceModel { get; set; }
      public int? Quantity { get; set; }
   }
   public enum HunterViolationFounderTypes : int
   {
      Informant = 1,
      Founder = 2,
      InformantAndFounder = 3
   }
}
