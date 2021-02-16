using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class DetailedPerson
   {
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public bool? SurvivalStatus { get; set; } // False = dead , True = Alive
      public string NationalCode { get; set; }
      public string FatherName { get; set; }
      public int? DateOfBirth { get; set; }
      public virtual EnumData Religion { get; set; }
      public int? ReligionId { get; set; }
      public string Faith { get; set; }
      public virtual EnumData Grade { get; set; }
      public int? GradeId { get; set; }
      public bool? MaritalStatus { get; set; } // False = Single, True = Married
   }

}
