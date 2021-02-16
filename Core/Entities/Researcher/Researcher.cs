using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class Researcher : IAuditableEntity
   {
      public Researcher()
      {
         Information = new DetailedPerson();
         Address = new PersonAddress();
         ForeignLanguages = new HashSet<ResearcherForeignLanguage>();
         Educations = new HashSet<ResearcherEducation>();
         Skills = new HashSet<ResearcherSkill>();
         DeputiesCooperationHistories = new HashSet<ResearcherDeputiesCooperationHistory>();
         ConferencePapers = new HashSet<ResearcherConferencePaper>();
         CompilationBooks = new HashSet<ResearcherCompilationBook>();
         Awards = new HashSet<ResearcherAward>();
         CourseWorkshops = new HashSet<ResearcherCourseWorkshop>();
         CommunityMemberships = new HashSet<ResearcherCommunityMembership>();
         IsiArticles = new HashSet<ResearcherIsiArticle>();
         JournalMagazines = new HashSet<ResearcherJournalMagazine>();
      }
      public int Id { get; set; }
      public virtual DetailedPerson Information { get; set; }
      public virtual PersonAddress Address { get; set; }
      public string WorkplaceName { get; set; }
      public string WorkplaceAddress { get; set; }
      public string WorkplacePhone { get; set; }

      // Files
      public virtual Upload PhotoFileName { get; set; }

      [StringLength(38)]
      public string PhotoFileNameId { get; set; }
      public virtual ICollection<ResearcherForeignLanguage> ForeignLanguages { get; set; }
      public virtual ICollection<ResearcherEducation> Educations { get; set; }
      public virtual ICollection<ResearcherSkill> Skills { get; set; }
      public virtual ICollection<ResearcherDeputiesCooperationHistory> DeputiesCooperationHistories { get; set; }
      public virtual ICollection<ResearcherConferencePaper> ConferencePapers { get; set; }
      public virtual ICollection<ResearcherCompilationBook> CompilationBooks { get; set; }
      public virtual ICollection<ResearcherAward> Awards { get; set; }
      public virtual ICollection<ResearcherCourseWorkshop> CourseWorkshops { get; set; }
      public virtual ICollection<ResearcherCommunityMembership> CommunityMemberships { get; set; }
      public virtual ICollection<ResearcherIsiArticle> IsiArticles { get; set; }
      public virtual ICollection<ResearcherJournalMagazine> JournalMagazines { get; set; }
   }
}
