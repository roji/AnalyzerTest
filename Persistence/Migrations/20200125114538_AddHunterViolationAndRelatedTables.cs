using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddHunterViolationAndRelatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HunterViolations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ViolationObserveDate = table.Column<int>(nullable: true),
                    ViolatedProvinceId = table.Column<int>(nullable: true),
                    ViolatedStateId = table.Column<int>(nullable: true),
                    ViolatedRegionId = table.Column<int>(nullable: true),
                    ViolationStartedDate = table.Column<int>(nullable: true),
                    CaseNumber = table.Column<string>(nullable: true),
                    ViolationDegreeId = table.Column<int>(nullable: true),
                    RuleStatusId = table.Column<int>(nullable: true),
                    RuleRegisterDate = table.Column<int>(nullable: true),
                    RuleNumber = table.Column<string>(nullable: true),
                    DeprivationTypeId = table.Column<int>(nullable: true),
                    DeprivationDate = table.Column<int>(nullable: true),
                    DeprivationDescription = table.Column<string>(nullable: true),
                    DeprivationFromDate = table.Column<int>(nullable: true),
                    DeprivationToDate = table.Column<int>(nullable: true),
                    DeprivationResult = table.Column<string>(nullable: true),
                    HasJail = table.Column<bool>(nullable: true),
                    DaysInJail = table.Column<int>(nullable: true),
                    MonthsInJail = table.Column<int>(nullable: true),
                    YearsInJail = table.Column<int>(nullable: true),
                    HasCashPenalty = table.Column<bool>(nullable: true),
                    CashPenalty = table.Column<double>(nullable: true),
                    HasOtherPenalty = table.Column<bool>(nullable: true),
                    OtherPenaltyDescription = table.Column<string>(nullable: true),
                    RemainedLossingQuantity = table.Column<double>(nullable: true),
                    RemainedLossingDescription = table.Column<string>(nullable: true),
                    PaidLossingQuantity = table.Column<double>(nullable: true),
                    PaidLossingDescription = table.Column<string>(nullable: true),
                    RuleFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    ViolatorPartnerFullName = table.Column<string>(nullable: true),
                    ViolatorPartnerNationalCode = table.Column<string>(nullable: true),
                    ViolatorPartnerMobile = table.Column<string>(nullable: true),
                    ViolatorPartnerAddress = table.Column<string>(nullable: true),
                    FounderType = table.Column<int>(nullable: true),
                    FounderPartnerFullName = table.Column<string>(nullable: true),
                    FounderPartnerNationalCode = table.Column<string>(nullable: true),
                    FounderPartnerMobile = table.Column<string>(nullable: true),
                    FounderPartnerAddress = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_HunterViolations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HunterViolations_EnumData_DeprivationTypeId",
                        column: x => x.DeprivationTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HunterViolations_Hunters_HunterId",
                        column: x => x.HunterId,
                        principalTable: "Hunters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HunterViolations_Uploads_RuleFileNameId",
                        column: x => x.RuleFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HunterViolations_EnumData_RuleStatusId",
                        column: x => x.RuleStatusId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HunterViolations_EnumData_ViolatedProvinceId",
                        column: x => x.ViolatedProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HunterViolations_EnumData_ViolatedRegionId",
                        column: x => x.ViolatedRegionId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HunterViolations_EnumData_ViolatedStateId",
                        column: x => x.ViolatedStateId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HunterViolations_EnumData_ViolationDegreeId",
                        column: x => x.ViolationDegreeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HunterSeizedDevices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HunterViolationId = table.Column<int>(nullable: false),
                    DeviceTypeId = table.Column<int>(nullable: false),
                    DeviceModel = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_HunterSeizedDevices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HunterSeizedDevices_EnumData_DeviceTypeId",
                        column: x => x.DeviceTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HunterSeizedDevices_HunterViolations_HunterViolationId",
                        column: x => x.HunterViolationId,
                        principalTable: "HunterViolations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HunterViolatedSpecies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HunterViolationId = table.Column<int>(nullable: false),
                    SpecieId = table.Column<int>(nullable: false),
                    SubSpecieId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_HunterViolatedSpecies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HunterViolatedSpecies_HunterViolations_HunterViolationId",
                        column: x => x.HunterViolationId,
                        principalTable: "HunterViolations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HunterViolatedSpecies_EnumData_SpecieId",
                        column: x => x.SpecieId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HunterViolatedSpecies_EnumData_SubSpecieId",
                        column: x => x.SubSpecieId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HunterViolationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HunterViolationId = table.Column<int>(nullable: false),
                    ViolationTypeId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_HunterViolationTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HunterViolationTypes_HunterViolations_HunterViolationId",
                        column: x => x.HunterViolationId,
                        principalTable: "HunterViolations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HunterViolationTypes_EnumData_ViolationTypeId",
                        column: x => x.ViolationTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HunterSeizedDevices_DeviceTypeId",
                table: "HunterSeizedDevices",
                column: "DeviceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterSeizedDevices_HunterViolationId",
                table: "HunterSeizedDevices",
                column: "HunterViolationId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterViolatedSpecies_HunterViolationId",
                table: "HunterViolatedSpecies",
                column: "HunterViolationId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterViolatedSpecies_SpecieId",
                table: "HunterViolatedSpecies",
                column: "SpecieId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterViolatedSpecies_SubSpecieId",
                table: "HunterViolatedSpecies",
                column: "SubSpecieId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterViolations_DeprivationTypeId",
                table: "HunterViolations",
                column: "DeprivationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterViolations_HunterId",
                table: "HunterViolations",
                column: "HunterId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterViolations_RuleFileNameId",
                table: "HunterViolations",
                column: "RuleFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterViolations_RuleStatusId",
                table: "HunterViolations",
                column: "RuleStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterViolations_ViolatedProvinceId",
                table: "HunterViolations",
                column: "ViolatedProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterViolations_ViolatedRegionId",
                table: "HunterViolations",
                column: "ViolatedRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterViolations_ViolatedStateId",
                table: "HunterViolations",
                column: "ViolatedStateId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterViolations_ViolationDegreeId",
                table: "HunterViolations",
                column: "ViolationDegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterViolationTypes_HunterViolationId",
                table: "HunterViolationTypes",
                column: "HunterViolationId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterViolationTypes_ViolationTypeId",
                table: "HunterViolationTypes",
                column: "ViolationTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HunterSeizedDevices");

            migrationBuilder.DropTable(
                name: "HunterViolatedSpecies");

            migrationBuilder.DropTable(
                name: "HunterViolationTypes");

            migrationBuilder.DropTable(
                name: "HunterViolations");
        }
    }
}
