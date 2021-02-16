using System;
using System.Collections.Generic;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class IndustryEvaluationEnvironmentalManagementCertificates : IAuditableEntity
    {
        public int Id { get; set; }
        public virtual IndustryEvaluation IndustryEvaluation { get; set; }
        public int IndustryEvaluationId { get; set; }
        public virtual EnumData LicenseType { get; set; }
        public int LicenseTypeId { get; set; }
        public string LicenseExporterCompanyName { get; set; }
        public int? ReceiptDate { get; set; }
        public int? ExpireDate { get; set; }
        public int? ExtendedDate { get; set; }
    }
}
