using System.Collections.Generic;
using System.Security.Claims;

namespace Core.Contracts
{
    public interface IUserAccessInfoService
    {
        IDataClaim UserDataClaims {get;set;}
        int LoggedInUserId { get; set; }
        int LoggedInUserProvinceId { get; set; }
        List<string> UserClaims {get; set;}
        IEnumerable<string> GetLoggedInUserClaimTypes ();
        IEnumerable<Claim> GetLoggedInUserClaims ();
    }
}
