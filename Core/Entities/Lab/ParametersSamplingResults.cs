using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Core.Entities.AuditableEntity;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;

namespace Core.Entities
{
    public class ParametersSamplingResults : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        public virtual MonitoringParameters MonitoringParameters { get; set; }
        public int MonitoringParametersId { get; set; }
        // public EnumData ParamClassification { get; set; }
        // public int ParamClassificationId { get; set; }
        // public EnumData Param { get; set; }
        // public int ParamId { get; set; }
        public int MonitoringTypeId { get; set; }
        public int? WasteClassificationId { get; set; }
        public int? WasteNameId { get; set; }
        public int? FuelTypeId { get; set; }
        public int? PollutionReleaseSourceId { get; set; }
        public int? AcceptedResourceId { get; set; }
        public virtual EnumData MonitoringType { get; set; }
        public virtual EnumData WasteClassification { get; set; }
        public virtual EnumData WasteName { get; set; }
        public virtual EnumData FuelType { get; set; }
        public virtual EnumData PollutionReleaseSource { get; set; }
        public virtual EnumData AcceptedResource { get; set; }
        public int? SamplingDate { get; set; }
        public int? ExperimentDate { get; set; }
        [NotMapped]
        public ICollection<int> Equipments { get; set; }
        public string EquipmentsIds
        {
            get { return string.Join(",", Equipments); }
            set { if (!string.IsNullOrWhiteSpace(value)) { Equipments = value.Split(',').Select(int.Parse).ToList(); } }
        }
        public string ExperimentMethod { get; set; }
        public string Description { get; set; }
        public virtual Upload DocumentsFileName { get; set; }
        [StringLength(38)]
        public string DocumentsFileNameId { get; set; }
        public virtual ICollection<AmbientAirParametersResults> AmbientAirParametersResults { get; set; }
        public virtual ICollection<ChimneyParametersResults> ChimneyParametersResults { get; set; }
        public virtual ICollection<WastewaterParametersResults> WastewaterParametersResults { get; set; }
        public virtual ICollection<WasteParametersResults> WasteParametersResults { get; set; }
        public virtual ICollection<SoundAndWavesParametersResults> SoundAndWavesParametersResults { get; set; }
        public virtual IndustrialUnitsSamplingResult IndustrialUnitsSamplingResult { get; set; }
        public int IndustrialUnitsSamplingResultId { get; set; }
        public ParametersSamplingResults()
        {
            AmbientAirParametersResults = new List<AmbientAirParametersResults>();
            ChimneyParametersResults = new List<ChimneyParametersResults>();
            WastewaterParametersResults = new List<WastewaterParametersResults>();
            WasteParametersResults = new List<WasteParametersResults>();
            SoundAndWavesParametersResults = new List<SoundAndWavesParametersResults>();
            Equipments = new List<int>();
        }
    }
}
