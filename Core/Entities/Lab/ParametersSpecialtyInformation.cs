using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public enum ParamPollutionStatuses : int
   {
      [Display(Name = "عادی")] Normal = 1,

      [Display(Name = "بیشتر از حد مجاز")] Warning = 2,

      [Display(Name = "بیشتر از حد آلایندگی")] Danger = 3
   }
   public class AmbientAirParametersResults : IAuditableEntity, IAccessControl
   {
      public int Id { get; set; }
      public virtual ParametersSamplingResults ParametersSamplingResults { get; set; }
      public int ParametersSamplingResultsId { get; set; }
      public double? MeasurementDuration { get; set; }
      public string Longitude { get; set; }
      public string Latitude { get; set; }
      public string SamplingPlace { get; set; }
      public double Quantity { get; set; }
      public OperatorTypes Operator { get; set; }
      public ParamPollutionStatuses Status { get; set; }
   }
   public class ChimneyParametersResults : IAuditableEntity, IAccessControl
   {
      public int Id { get; set; }
      public virtual ParametersSamplingResults ParametersSamplingResults { get; set; }
      public int ParametersSamplingResultsId { get; set; }
      public double? MeasurementDuration { get; set; }
      public string Longitude { get; set; }
      public string Latitude { get; set; }
      public double Quantity { get; set; }
      public OperatorTypes Operator { get; set; }
      public string Code { get; set; }
      public double? EntryPointElevation { get; set; }
      public double? SamplingPlaceElevation { get; set; }
      public double? OxygenVolumePercentage { get; set; }
      public double? Temperature { get; set; }
      public double? DynamicPressure { get; set; }
      public double? AmbientPressure { get; set; }
      public double? RelativeHumidity { get; set; }
      public double? GasOutletDebi { get; set; }
      public double? DioxideCarbonVolumePercentage { get; set; }
      public double? ExtraAirVolumePercentage { get; set; }
      public double? ThermalEfficiencyPercentage { get; set; }
      public double? InnerDiameter { get; set; }
      public double? OutputGasSpeed { get; set; }
      public double? DryConditionDensity { get; set; }
      public double? WetConditionDensity { get; set; }
      public double? EnergyLoss { get; set; }
      public string Description { get; set; }
      public ParamPollutionStatuses Status { get; set; }
   }
   public class WastewaterParametersResults : IAuditableEntity, IAccessControl
   {
      public int Id { get; set; }
      public virtual ParametersSamplingResults ParametersSamplingResults { get; set; }
      public int ParametersSamplingResultsId { get; set; }
      public string VisualSpecs { get; set; }
      public double Quantity { get; set; }
      public OperatorTypes Operator { get; set; }
      public double? Debi { get; set; }
      public string Description { get; set; }
      public ParamPollutionStatuses Status { get; set; }
      public virtual EnumData WastewaterType { get; set; }
      public int? WastewaterTypeId { get; set; }
   }
   public class WasteParametersResults : IAuditableEntity, IAccessControl
   {
      public int Id { get; set; }
      public virtual ParametersSamplingResults ParametersSamplingResults { get; set; }
      public int ParametersSamplingResultsId { get; set; }
      public string VisualSpecs { get; set; }
      public string Condition { get; set; }
      public double Quantity { get; set; }
      public OperatorTypes Operator { get; set; }
      public string Description { get; set; }
      public ParamPollutionStatuses Status { get; set; }
   }
   public class SoundAndWavesParametersResults : IAuditableEntity, IAccessControl
   {
      public int Id { get; set; }
      public virtual ParametersSamplingResults ParametersSamplingResults { get; set; }
      public int ParametersSamplingResultsId { get; set; }
      public bool DayOrNight { get; set; } // Day = 0 , Night = 1
      public string SamplingPlace { get; set; }
      public string Longitude { get; set; }
      public string Latitude { get; set; }
      public double Quantity { get; set; }
      public OperatorTypes Operator { get; set; }
      public string Description { get; set; }
      public ParamPollutionStatuses Status { get; set; }
   }
}
