using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities.AuditableEntity;

namespace Core.Entities
{
    public class RiverPassingProvince : IAuditableEntity, IAccessControl
    {
        public int Id { get; set; }
        public virtual River River { get; set; }
        public int RiverId { get; set; }
        public virtual EnumData Province { get; set; }
        public int ProvinceId { get; set; }

        public static Expression<Func<RiverPassingProvince, bool>> GetEntityLimitation(IUserAccessInfoService uai)
        {
            return q =>
            (uai.UserClaims.Intersect(new string[] { "RiverFull", "RiverView", "god" })).Any() &&
            (uai.UserDataClaims._Skip_river ||
            (uai.UserDataClaims.River_province.Contains(q.ProvinceId)));
        }
        public static Expression<Func<RiverPassingProvince, bool>> GetSmartLimitations(IUserAccessInfoService uai) => GetEntityLimitation(uai);

    }
}

