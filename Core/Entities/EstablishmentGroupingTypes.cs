   using System.Collections.Generic;
   using System.ComponentModel.DataAnnotations;
   using System.Text.Json.Serialization;
   using Core.Entities.AuditableEntity;

   namespace Core.Entities
   {
      public enum EstablishmentGroupingTypes : int
      {
         [Display(Name = "صنعتی")] Industrial = 1,

         [Display(Name = "خدماتی")] Services = 2,

         [Display(Name = "معدنی")] Mineral = 3,
      }
   }
