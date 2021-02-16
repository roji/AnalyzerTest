using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddHunterWeaponHistoriesAndToolsHistoriesTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FishermanToolsHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ToolsTypeId = table.Column<int>(nullable: false),
                    ToolsModelId = table.Column<int>(nullable: false),
                    ToolsCountryId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    HunterId = table.Column<int>(nullable: false),
                    CreatedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishermanToolsHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FishermanToolsHistories_Hunters_HunterId",
                        column: x => x.HunterId,
                        principalTable: "Hunters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FishermanToolsHistories_EnumData_ToolsCountryId",
                        column: x => x.ToolsCountryId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FishermanToolsHistories_EnumData_ToolsModelId",
                        column: x => x.ToolsModelId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FishermanToolsHistories_EnumData_ToolsTypeId",
                        column: x => x.ToolsTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HunterWeaponHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WeaponTypeId = table.Column<int>(nullable: false),
                    WeaponModelId = table.Column<int>(nullable: false),
                    WeaponCountryId = table.Column<int>(nullable: true),
                    Caliber = table.Column<double>(nullable: true),
                    WeaponNumber = table.Column<string>(nullable: true),
                    WeaponTransportingLicenseNumber = table.Column<string>(nullable: true),
                    WeaponTransportingLicenseRegisterDate = table.Column<int>(nullable: true),
                    LicenseRegisterProvinceId = table.Column<int>(nullable: true),
                    LicenseRegisterStateId = table.Column<int>(nullable: true),
                    LicenseRegisterCityId = table.Column<int>(nullable: true),
                    LicenseIsValidFromDate = table.Column<int>(nullable: true),
                    LicenseIsValidToDate = table.Column<int>(nullable: true),
                    WeaponTransportingLicenseFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    HunterId = table.Column<int>(nullable: false),
                    CreatedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HunterWeaponHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HunterWeaponHistories_Hunters_HunterId",
                        column: x => x.HunterId,
                        principalTable: "Hunters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HunterWeaponHistories_EnumData_LicenseRegisterCityId",
                        column: x => x.LicenseRegisterCityId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HunterWeaponHistories_EnumData_LicenseRegisterProvinceId",
                        column: x => x.LicenseRegisterProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HunterWeaponHistories_EnumData_LicenseRegisterStateId",
                        column: x => x.LicenseRegisterStateId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HunterWeaponHistories_EnumData_WeaponCountryId",
                        column: x => x.WeaponCountryId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HunterWeaponHistories_EnumData_WeaponModelId",
                        column: x => x.WeaponModelId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HunterWeaponHistories_Uploads_WeaponTransportingLicenseFileN~",
                        column: x => x.WeaponTransportingLicenseFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HunterWeaponHistories_EnumData_WeaponTypeId",
                        column: x => x.WeaponTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FishermanToolsHistories_HunterId",
                table: "FishermanToolsHistories",
                column: "HunterId");

            migrationBuilder.CreateIndex(
                name: "IX_FishermanToolsHistories_ToolsCountryId",
                table: "FishermanToolsHistories",
                column: "ToolsCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_FishermanToolsHistories_ToolsModelId",
                table: "FishermanToolsHistories",
                column: "ToolsModelId");

            migrationBuilder.CreateIndex(
                name: "IX_FishermanToolsHistories_ToolsTypeId",
                table: "FishermanToolsHistories",
                column: "ToolsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterWeaponHistories_HunterId",
                table: "HunterWeaponHistories",
                column: "HunterId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterWeaponHistories_LicenseRegisterCityId",
                table: "HunterWeaponHistories",
                column: "LicenseRegisterCityId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterWeaponHistories_LicenseRegisterProvinceId",
                table: "HunterWeaponHistories",
                column: "LicenseRegisterProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterWeaponHistories_LicenseRegisterStateId",
                table: "HunterWeaponHistories",
                column: "LicenseRegisterStateId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterWeaponHistories_WeaponCountryId",
                table: "HunterWeaponHistories",
                column: "WeaponCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterWeaponHistories_WeaponModelId",
                table: "HunterWeaponHistories",
                column: "WeaponModelId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterWeaponHistories_WeaponTransportingLicenseFileNameId",
                table: "HunterWeaponHistories",
                column: "WeaponTransportingLicenseFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterWeaponHistories_WeaponTypeId",
                table: "HunterWeaponHistories",
                column: "WeaponTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FishermanToolsHistories");

            migrationBuilder.DropTable(
                name: "HunterWeaponHistories");
        }
    }
}
