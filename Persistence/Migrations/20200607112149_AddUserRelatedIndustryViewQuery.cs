using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddUserRelatedIndustryViewQuery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var cmd = @"CREATE VIEW v_userrelatedindustry AS 
                    ( SELECT
                            users.Id,
                            users.Username,
                            users.FullName,
                            users.IsActive,
                            users.CreatedDateTime AS UserRegisterDate,
                            users.LastLoggedIn AS UserLastLoggedIn,
                            roleclaims.CreatedDateTime AS AssignedClaimDate,
                            industry.Id AS IndustryId,
                            industry.`Name` AS IndustryName,
                            IndustryProvince.Title AS IndustryProvince,
                            IndustryProvince.Id AS IndustryProvinceId,
                            IndustryState.Title AS IndustryState,
                            IndustryState.Id AS IndustryStateId,
                            UserProvince.Title AS UserProvince,
                            UserProvince.Id AS UserProvinceId,
                            UserState.Title AS UserState,
                            UserState.Id AS UserStateId,
                            EstablishmentGrouping.Title AS EstablishmentGrouping,
                            EstablishmentGrouping.Id AS EstablishmentGroupingId,
                            EstablishmentGroupingClassification.Title AS EstablishmentGroupingClassification,
                            EstablishmentGroupingClassification.Id AS EstablishmentGroupingClassificationId,
                            IsicCode2.`Data` AS IsicCode2,
                            IsicCode2.Id AS IsicCode2Id,
                            IsicCode4.`Data` AS IsicCode4,
                            IsicCode4.Id AS IsicCode4Id 
                            FROM
                                users
                                JOIN userroles ON userroles.UserId = users.Id
                                JOIN roles ON userroles.RoleId = roles.Id
                                JOIN roleclaims ON roleclaims.RoleId = roles.Id
                                LEFT JOIN industries industry ON industry.Id = roleclaims.ClaimValue
                                LEFT JOIN industry_workshopaddresses address ON address.IndustryId = industry.Id
                                LEFT JOIN enumdata IndustryProvince ON IndustryProvince.Id = address.ProvinceId
                                LEFT JOIN enumdata IndustryState ON IndustryState.Id = address.StateId
                                LEFT JOIN enumdata EstablishmentGrouping ON EstablishmentGrouping.Id = industry.EstablishmentGroupingId
                                LEFT JOIN enumdata EstablishmentGroupingClassification ON EstablishmentGroupingClassification.Id = EstablishmentGrouping.ParentId
                                LEFT JOIN enumdata IsicCode4 ON IsicCode4.Id = industry.IsicCodeId
                                LEFT JOIN enumdata IsicCode2 ON IsicCode2.Id = IsicCode4.ParentId
                                LEFT JOIN enumdata UserProvince ON UserProvince.Id = users.ProvinceId
                                LEFT JOIN enumdata UserState ON UserState.Id = users.StateId 
                            WHERE
                                roleclaims.ClaimType = ""dlc_industry_id""
                            ) UNION ALL
                            (
                            SELECT
                                users.Id,
                                users.Username,
                                users.FullName,
                                users.IsActive,
                                users.CreatedDateTime AS UserRegisterDate,
                                users.LastLoggedIn AS UserLastLoggedIn,
                                userclaims.CreatedDateTime AS AssignedClaimDate,
                                industry.Id AS IndustryId,
                                industry.`Name` AS IndustryName,
                                IndustryProvince.Title AS IndustryProvince,
                                IndustryProvince.Id AS IndustryProvinceId,
                                IndustryState.Title AS IndustryState,
                                IndustryState.Id AS IndustryStateId,
                                UserProvince.Title AS UserProvince,
                                UserProvince.Id AS UserProvinceId,
                                UserState.Title AS UserState,
                                UserState.Id AS UserStateId,
                                EstablishmentGrouping.Title AS EstablishmentGrouping,
                                EstablishmentGrouping.Id AS EstablishmentGroupingId,
                                EstablishmentGroupingClassification.Title AS EstablishmentGroupingClassification,
                                EstablishmentGroupingClassification.Id AS EstablishmentGroupingClassificationId,
                                IsicCode2.`Data` AS IsicCode2,
                                IsicCode2.Id AS IsicCode2Id,
                                IsicCode4.`Data` AS IsicCode4,
                                IsicCode4.Id AS IsicCode4Id
                            FROM
                                users
                                JOIN userclaims ON userclaims.UserId = users.Id
                                LEFT JOIN industries industry ON industry.Id = userclaims.ClaimValue
                                LEFT JOIN industry_workshopaddresses address ON address.IndustryId = industry.Id
                                LEFT JOIN enumdata IndustryProvince ON IndustryProvince.Id = address.ProvinceId
                                LEFT JOIN enumdata IndustryState ON IndustryState.Id = address.StateId
                                LEFT JOIN enumdata EstablishmentGrouping ON EstablishmentGrouping.Id = industry.EstablishmentGroupingId
                                LEFT JOIN enumdata EstablishmentGroupingClassification ON EstablishmentGroupingClassification.Id = EstablishmentGrouping.ParentId
                                LEFT JOIN enumdata IsicCode4 ON IsicCode4.Id = industry.IsicCodeId
                                LEFT JOIN enumdata IsicCode2 ON IsicCode2.Id = IsicCode4.ParentId
                                LEFT JOIN enumdata UserProvince ON UserProvince.Id = users.ProvinceId
                                LEFT JOIN enumdata UserState ON UserState.Id = users.StateId
                            WHERE
                                userclaims.ClaimType = ""dlc_industry_id""
                            )
                        ORDER BY AssignedClaimDate DESC";
            migrationBuilder.Sql(cmd);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var cmd = @"DROP VIEW IF EXISTS `v_userrelatedindustry`;";
            migrationBuilder.Sql(cmd);
        }
    }
}
