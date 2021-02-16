using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
   public class KnowledgeBase : IAccessControl, IAuditableEntity
   {
      public int Id { get; set; }
      public string Title { get; set; }
      public string Description { get; set; }
      public int? KnowledgeBaseGroupId { get; set; }
      public bool IsPublic { get; set; }
      public virtual EnumData KnowledgeBaseGroup { get; set; }

      [StringLength(38)]
      public string DocumentFileNameId { get; set; }
      public virtual Upload DocumentFileName { get; set; }

      public static Expression<Func<KnowledgeBase, bool>> GetEntityLimitation(IUserAccessInfoService uai)
      {
         return q =>
            (uai.LoggedInUserId > 0 && uai.UserClaims.Intersect(new string[] { "god" }).Any()) ||
            ((q.IsPublic) ||
               (!q.IsPublic && uai.UserDataClaims.Knowledgebase_group.Contains(q.KnowledgeBaseGroupId)));
      }

      public static Expression<Func<KnowledgeBase, bool>> GetSmartLimitations(IUserAccessInfoService uai) => GetEntityLimitation(uai);
   }
}
