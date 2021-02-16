using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;
using Core.Entities.AuditableEntity;
namespace Core.Entities
{
   public class Personnel : IAuditableEntity, IAccessControl
   {
      public Personnel()
      {
         Experiences = new HashSet<PersonnelExperience>();
      }

      public int Id { get; set; }
      public string Name { get; set; }
      public string NationalCode { get; set; }
      public virtual Upload PersonnelHistoryFileName { get; set; }

      [StringLength(38)]
      public string PersonnelHistoryFileNameId { get; set; }
      public virtual Upload NationalCardPhotoFileName { get; set; }

      [StringLength(38)]
      public string NationalCardPhotoFileNameId { get; set; }
      public virtual Upload DegreeOfEducationFileName { get; set; }

      [StringLength(38)]
      public string DegreeOfEducationFileNameId { get; set; }
      public int? MajorId { get; set; }
      public virtual EnumData Major { get; set; }
      public int? GradeId { get; set; }
      public virtual EnumData Grade { get; set; }
      public int? RankId { get; set; }
      public virtual EnumData Rank { get; set; }
      public int LabId { get; set; }
      public virtual Lab Lab { get; set; }
      public virtual ICollection<PersonnelExperience> Experiences { get; set; }
      public int? CooperationStartingDate { get; set; }
      public int? CooperationEndingDate { get; set; }
   }
   public class PersonnelExperience : IAuditableEntity, IAccessControl
   {
      public int Id { get; set; }
      public int MonitoringTypeId { get; set; }
      public virtual EnumData MonitoringType { get; set; }
      public int Experience { get; set; }
      public int PersonnelId { get; set; }
      public virtual Personnel Personnel { get; set; }
   }
}
