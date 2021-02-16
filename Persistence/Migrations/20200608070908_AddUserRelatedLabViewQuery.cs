using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddUserRelatedLabViewQuery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var cmd = @"CREATE VIEW v_userrelatedlab AS 
                   ( SELECT
                    users.Id,
                    users.Username,
                    users.FullName,
                    users.IsActive,
                    users.CreatedDateTime AS UserRegisterDate,
                    users.LastLoggedIn AS UserLastLoggedIn,
                    roleclaims.CreatedDateTime AS AssignedClaimDate,
                    Lab.Id AS LabId,
                    Lab.`Name` AS LabName,
                    LabProvince.Title AS LabProvince,
                    LabProvince.Id AS LabProvinceId,
                    LabState.Title AS LabState,
                    LabState.Id AS LabStateId,
                    UserProvince.Title AS UserProvince,
                    UserProvince.Id AS UserProvinceId,
                    UserState.Title AS UserState,
                    UserState.Id AS UserStateId,
                    Classification.Title AS Classification,
                    Classification.Id AS ClassificationId 
                    FROM
                        users
                        JOIN userroles ON userroles.UserId = users.Id
                        JOIN roles ON userroles.RoleId = roles.Id
                        JOIN roleclaims ON roleclaims.RoleId = roles.Id
                        LEFT JOIN labs lab ON lab.Id = roleclaims.ClaimValue
                        LEFT JOIN lab_addresses address ON address.labId = lab.Id
                        LEFT JOIN enumdata LabProvince ON LabProvince.Id = address.ProvinceId
                        LEFT JOIN enumdata LabState ON LabState.Id = address.StateId
                        LEFT JOIN enumdata Classification ON Classification.Id = lab.ClassificationId
                        LEFT JOIN enumdata UserProvince ON UserProvince.Id = users.ProvinceId
                        LEFT JOIN enumdata UserState ON UserState.Id = users.StateId 
                    WHERE
                        roleclaims.ClaimType = ""dlc_lab_id"" 
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
                        Lab.Id AS LabId,
                        Lab.`Name` AS LabName,
                        LabProvince.Title AS LabProvince,
                        LabProvince.Id AS LabProvinceId,
                        LabState.Title AS LabState,
                        LabState.Id AS LabStateId,
                        UserProvince.Title AS UserProvince,
                        UserProvince.Id AS UserProvinceId,
                        UserState.Title AS UserState,
                        UserState.Id AS UserStateId,
                        Classification.Title AS Classification,
                        Classification.Id AS ClassificationId
                    FROM

                        users
                        JOIN userclaims ON userclaims.UserId = users.Id

                        LEFT JOIN labs lab ON lab.Id = userclaims.ClaimValue

                        LEFT JOIN lab_addresses address ON address.labId = lab.Id

                        LEFT JOIN enumdata LabProvince ON LabProvince.Id = address.ProvinceId

                        LEFT JOIN enumdata LabState ON LabState.Id = address.StateId

                        LEFT JOIN enumdata Classification ON Classification.Id = lab.ClassificationId

                        LEFT JOIN enumdata UserProvince ON UserProvince.Id = users.ProvinceId

                        LEFT JOIN enumdata UserState ON UserState.Id = users.StateId

                    WHERE
                        userclaims.ClaimType = ""dlc_lab_id""
                    )
                ORDER BY

                    AssignedClaimDate DESC";
            migrationBuilder.Sql(cmd);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var cmd = @"DROP VIEW IF EXISTS `v_userrelatedlab`;";
            migrationBuilder.Sql(cmd);
        }
    }
}
