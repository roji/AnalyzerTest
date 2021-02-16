using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Core.Entities.AuditableEntity;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;
using System.Linq.Expressions;
using Core.Tools;

namespace Core.Entities
{
    public class LabRankingCoding : IAuditableEntity
    {
        public LabRankingCoding()
        {
            ExpertPersonnels = new HashSet<LabRankingCodingExpertPersonnel>();
            Parameters = new HashSet<LabRankingCodingParameter>();
        }
        public int Id { get; set; }
        public virtual EnumData MonitoringType { get; set; }
        public int MonitoringTypeId { get; set; }
        public int Rating { get; set; }
        public int LabBackgroundRecord { get; set; }
        public double SpaceMeasurement { get; set; }
        public double SpaceScore { get; set; }
        public double PlatformMeasurement { get; set; }
        public double PlatformScore { get; set; }
        public virtual EnumData OwnershipStatus { get; set; }
        public int OwnershipStatusId { get; set; }
        public double OwnershipStatusScore { get; set; }
        public bool IsPlatformNecessary { get; set; }
        public double LabLocationMinimumScore { get; set; }
        public double MinScoreLimit { get; set; }
        public double MaxScoreLimit { get; set; }
        public virtual ICollection<LabRankingCodingExpertPersonnel> ExpertPersonnels { get; set; }
        public virtual ICollection<LabRankingCodingParameter> Parameters { get; set; }
    }
}
