using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class IndustryEvaluation : IAuditableEntity, IAccessControl
   {
      public int Id { get; set; }
      public virtual Industry Industry { get; set; }
      public int IndustryId { get; set; }
      public double? UnitTotalArea { get; set; }
      public bool? IsDevelopingGreenSpace { get; set; }
      public double? GreenSpaceCoveringArea { get; set; }
      public virtual EnumData WateringSystemType { get; set; }
      public int? WateringSystemTypeId { get; set; }
      public string GreenSpacePlacesDescription { get; set; }
      public double? GreenSpaceCost { get; set; }
      public int? RelatedNonExpertPersonnel { get; set; }
      public int? RelatedExpertPersonnel { get; set; }
      public virtual UnitSaleStatuses? UnitSaleStatus { get; set; }
      public bool? SelectedAsGreenIndustryBefore { get; set; }
      public virtual EstablishmentEvaluationStatuses? EstablishmentEvaluationStatus { get; set; }
      public string EesDescription { get; set; }
      public bool? HasEvaluationStudies { get; set; }
      public string CommitmentsList { get; set; }
      public string LicenseNumber { get; set; }
      public int? LicenseDate { get; set; }
      public bool? EnvironmentalRequirementsSpecifiedObserved { get; set; }
      public string ErsoDescription { get; set; }
      public bool? HasEmpProgram { get; set; }
      public virtual Upload EmpProgramFileName { get; set; }

      [StringLength(38)]
      public string EmpProgramFileNameId { get; set; }
      public virtual ICollection<IndustryEvaluationGreenSpaceSpeciesVegetations> GreenSpaceSpeciesVegetations { get; set; }
      public virtual ICollection<IndustryEvaluationEnvironmentalManagementCertificates> EnvironmentalManagementCertificates { get; set; }
      public virtual ICollection<IndustryEvaluationUnitSaleInformations> UnitSaleInformations { get; set; }
      public virtual ICollection<IndustryEvaluationSelectedAsGreenIndustryInformations> SelectedAsGreenIndustryInformations { get; set; }
      public double? FacilityInfrastructure { get; set; }
      public string Dimensions { get; set; }
      public string ActivityAndEnvironmentalHistory { get; set; }
      public string UnitHomogeneityAndCoordinationWithEnvironment { get; set; }
      public string HseExpertFullName { get; set; }
      public string HseExpertMobile { get; set; }
      public string HseExpertEmail { get; set; }
      public IndustryEvaluation()
      {
         GreenSpaceSpeciesVegetations = new HashSet<IndustryEvaluationGreenSpaceSpeciesVegetations>();
         EnvironmentalManagementCertificates = new HashSet<IndustryEvaluationEnvironmentalManagementCertificates>();
         UnitSaleInformations = new HashSet<IndustryEvaluationUnitSaleInformations>();
         SelectedAsGreenIndustryInformations = new HashSet<IndustryEvaluationSelectedAsGreenIndustryInformations>();
      }
      public enum UnitSaleStatuses : int
      {
         Paid = 1,
         NotPaid = 2
      }
      public enum EstablishmentEvaluationStatuses : int
      {
         MeetsCriteria = 1,
         NotMeetsCriteria = 2
      }

   }
}
