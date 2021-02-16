using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddMineSpecialityInfoAndMineSpecialtyInfoMineralMaterialTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MineSpecialtyInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdentityNumber = table.Column<string>(nullable: true),
                    MineTypeId = table.Column<int>(nullable: false),
                    MineralGroupId = table.Column<int>(nullable: false),
                    RangeArea = table.Column<double>(nullable: true),
                    IsInsideProtectedArea = table.Column<bool>(nullable: true),
                    ProtectedAreaName = table.Column<string>(nullable: true),
                    RiverId = table.Column<int>(nullable: true),
                    DistanceToRiver = table.Column<double>(nullable: true),
                    IsInsideRiverRange = table.Column<bool>(nullable: true),
                    QualityOfWaterCloseToMineDescription = table.Column<string>(nullable: true),
                    HarvestingMaterialDepth = table.Column<double>(nullable: true),
                    OperatingLicenseFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    ExplorationLicenseFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    IndustryId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_MineSpecialtyInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MineSpecialtyInfos_Uploads_ExplorationLicenseFileNameId",
                        column: x => x.ExplorationLicenseFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MineSpecialtyInfos_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MineSpecialtyInfos_EnumData_MineTypeId",
                        column: x => x.MineTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MineSpecialtyInfos_EnumData_MineralGroupId",
                        column: x => x.MineralGroupId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MineSpecialtyInfos_Uploads_OperatingLicenseFileNameId",
                        column: x => x.OperatingLicenseFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MineSpecialtyInfos_Rivers_RiverId",
                        column: x => x.RiverId,
                        principalTable: "Rivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MineSpecialtyInfoMineralMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MineralMaterialId = table.Column<int>(nullable: false),
                    MineSpecialtyInfoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MineSpecialtyInfoMineralMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MineSpecialtyInfoMineralMaterials_MineSpecialtyInfos_MineSpe~",
                        column: x => x.MineSpecialtyInfoId,
                        principalTable: "MineSpecialtyInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MineSpecialtyInfoMineralMaterials_EnumData_MineralMaterialId",
                        column: x => x.MineralMaterialId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MineSpecialtyInfoMineralMaterials_MineSpecialtyInfoId",
                table: "MineSpecialtyInfoMineralMaterials",
                column: "MineSpecialtyInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_MineSpecialtyInfoMineralMaterials_MineralMaterialId",
                table: "MineSpecialtyInfoMineralMaterials",
                column: "MineralMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_MineSpecialtyInfos_ExplorationLicenseFileNameId",
                table: "MineSpecialtyInfos",
                column: "ExplorationLicenseFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_MineSpecialtyInfos_IndustryId",
                table: "MineSpecialtyInfos",
                column: "IndustryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MineSpecialtyInfos_MineTypeId",
                table: "MineSpecialtyInfos",
                column: "MineTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MineSpecialtyInfos_MineralGroupId",
                table: "MineSpecialtyInfos",
                column: "MineralGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_MineSpecialtyInfos_OperatingLicenseFileNameId",
                table: "MineSpecialtyInfos",
                column: "OperatingLicenseFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_MineSpecialtyInfos_RiverId",
                table: "MineSpecialtyInfos",
                column: "RiverId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MineSpecialtyInfoMineralMaterials");

            migrationBuilder.DropTable(
                name: "MineSpecialtyInfos");
        }
    }
}
