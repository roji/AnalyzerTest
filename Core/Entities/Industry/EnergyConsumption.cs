using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class EnergyConsumption : IAuditableEntity, IAccessControl
   {
      public int Id { get; set; }
      public bool HasElectricityConsumption { get; set; }
      public string EcSupplySourceLocationName { get; set; }
      public int? EcSpringAverageConsumption { get; set; }
      public int? EcSummerAverageConsumption { get; set; }
      public int? EcAutumnAverageConsumption { get; set; }
      public int? EcWinterAverageConsumption { get; set; }
      public bool HasGasConsumption { get; set; }
      public string GcSupplySourceLocationName { get; set; }
      public int? GcSpringAverageConsumption { get; set; }
      public int? GcSummerAverageConsumption { get; set; }
      public int? GcAutumnAverageConsumption { get; set; }
      public int? GcWinterAverageConsumption { get; set; }
      public bool HasMazutConsumption { get; set; }
      public string McSupplySourceLocationName { get; set; }
      public int? McSpringAverageConsumption { get; set; }
      public int? McSummerAverageConsumption { get; set; }
      public int? McAutumnAverageConsumption { get; set; }
      public int? McWinterAverageConsumption { get; set; }
      public bool HasGasolineConsumption { get; set; }
      public string GlcSupplySourceLocationName { get; set; }
      public int? GlcSpringAverageConsumption { get; set; }
      public int? GlcSummerAverageConsumption { get; set; }
      public int? GlcAutumnAverageConsumption { get; set; }
      public int? GlcWinterAverageConsumption { get; set; }
      public string Description { get; set; }
      public int IndustryId { get; set; }
      public virtual Industry Industry { get; set; }
      public int Year { get; set; }
      public bool? GeneralManagerVote { get; set; }
      public string GeneralManagerDescription { get; set; }
      public virtual User GeneralManagerUser { get; set; }
      public int? GeneralManagerUserId { get; set; }
      public bool? ApprovingOrganizationVote { get; set; }
      public string ApprovingOrganizationDescription { get; set; }
      public virtual User ApprovingOrganizationUser { get; set; }
      public int? ApprovingOrganizationUserId { get; set; }
      public DateTimeOffset? GeneralManagerVoteDateTime { get; set; }
      public DateTimeOffset? ApprovingOrganizationVoteDateTime { get; set; }
      public virtual Upload DocumentFileName { get; set; }

      [StringLength(38)] public string DocumentFileNameId { get; set; }
   }
}
