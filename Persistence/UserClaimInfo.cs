using System;
using System.Collections.Generic;
using System.Linq;

namespace Persistence
{

   public class UserClaimInfo : Dictionary<string, IEnumerable<int>>
   {

      public UserClaimInfo() => this.AddClaims("god");
      public UserClaimInfo AddClaims(string accessClaimName)
      {
         if (accessClaimName.StartsWith("dlc_")) throw new ArgumentException($"Access claim {accessClaimName} is not valid.");
         this.Add(accessClaimName, new int[0]);
         return this;
      }
      public UserClaimInfo AddClaims(IEnumerable<string> accessClaimNames)
      {
         foreach (var cn in accessClaimNames)
         {
            if (cn.StartsWith("dlc_")) throw new ArgumentException($"Access claim {cn} is not valid.");
            this.Add(cn, new int[0]);
         }
         return this;
      }

      public UserClaimInfo AddLimitationClaim(string limitationClaimName, IEnumerable<int> limitationValues)
      {
         if (!limitationClaimName.StartsWith("dlc_")) throw new ArgumentException($"Limitation claim {limitationClaimName} is not valid.");
         this.Add(limitationClaimName, limitationValues);
         return this;
      }

      public UserClaimInfo AddLimitationClaim(Dictionary<string, int[]> claimName_Values)
      {
         foreach (var cn in claimName_Values)
         {
            if (!cn.Key.StartsWith("dlc_")) throw new ArgumentException($"Limitation claim {cn} is not valid.");
            this.Add(cn.Key, cn.Value);
         }
         return this;
      }
      public IEnumerable<string> AllClaimNames { get { return this.Keys; } }
      public IEnumerable<string> AccessClaimNames { get { return this.Keys.Where(q => !q.StartsWith("dlc_")); } }
      public IEnumerable<string> LimitationClaimNames { get { return this.Keys.Where(q => q.StartsWith("dlc_")); } }

      public IEnumerable<KeyValuePair<string, IEnumerable<int>>> AllClaims { get { return this; } }
      public IEnumerable<KeyValuePair<string, IEnumerable<int>>> AccessClaims { get { return this.Where(q => !q.Key.StartsWith("dlc_")); } }
      public IEnumerable<KeyValuePair<string, IEnumerable<int>>> LimitationClaims { get { return this.Where(q => q.Key.StartsWith("dlc_")); } }

   }
}