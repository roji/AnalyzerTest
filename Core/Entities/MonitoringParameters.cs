using System.Collections;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class MonitoringParameters : IAuditableEntity
   {
      public int Id { get; set; }
      public int ParamClassificationId { get; set; }
      public virtual EnumData ParamClassification { get; set; }
      public int ParamId { get; set; }
      public virtual EnumData Param { get; set; }
      public int MonitoringCodingId { get; set; }
      public double LimitAmountQuantity { get; set; }
      public double PollutionLimitQuantity { get; set; }
      public virtual MonitoringCoding MonitoringCoding { get; set; }
      public virtual ICollection<ParametersSamplingResults> ParametersSamplingResults { get; set; }
   }
}
