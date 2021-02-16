using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddLabRankingAndRelatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LabRankingCodings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SpecializedGroup = table.Column<int>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    LabBackgroundRecord = table.Column<int>(nullable: false),
                    ParamClassificationId = table.Column<int>(nullable: false),
                    ScoreLimit = table.Column<double>(nullable: false),
                    SpaceMeasurement = table.Column<double>(nullable: false),
                    SpaceScore = table.Column<double>(nullable: false),
                    PlatformMeasurement = table.Column<double>(nullable: false),
                    PlatformScore = table.Column<double>(nullable: false),
                    OwnershipStatusId = table.Column<int>(nullable: false),
                    OwnershipStatusScore = table.Column<double>(nullable: false),
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
                    table.PrimaryKey("PK_LabRankingCodings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LabRankingCodings_EnumData_OwnershipStatusId",
                        column: x => x.OwnershipStatusId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LabRankingCodings_EnumData_ParamClassificationId",
                        column: x => x.ParamClassificationId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LabRankingCodingExpertPersonnels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RankId = table.Column<int>(nullable: false),
                    PersonnelQuantity = table.Column<int>(nullable: true),
                    PersonnelBackgroundRecord = table.Column<int>(nullable: true),
                    PriorityCoefficient = table.Column<int>(nullable: true),
                    IsNecessary = table.Column<bool>(nullable: false),
                    LabRankingCodingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabRankingCodingExpertPersonnels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LabRankingCodingExpertPersonnels_LabRankingCodings_LabRankin~",
                        column: x => x.LabRankingCodingId,
                        principalTable: "LabRankingCodings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LabRankingCodingExpertPersonnels_EnumData_RankId",
                        column: x => x.RankId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LabRankingCodingParameters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParameterId = table.Column<int>(nullable: false),
                    Score = table.Column<double>(nullable: false),
                    IsNecessary = table.Column<bool>(nullable: false),
                    LabRankingCodingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabRankingCodingParameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LabRankingCodingParameters_LabRankingCodings_LabRankingCodin~",
                        column: x => x.LabRankingCodingId,
                        principalTable: "LabRankingCodings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LabRankingCodingParameters_EnumData_ParameterId",
                        column: x => x.ParameterId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LabRankingCodingExpertPersonnels_LabRankingCodingId",
                table: "LabRankingCodingExpertPersonnels",
                column: "LabRankingCodingId");

            migrationBuilder.CreateIndex(
                name: "IX_LabRankingCodingExpertPersonnels_RankId",
                table: "LabRankingCodingExpertPersonnels",
                column: "RankId");

            migrationBuilder.CreateIndex(
                name: "IX_LabRankingCodingParameters_LabRankingCodingId",
                table: "LabRankingCodingParameters",
                column: "LabRankingCodingId");

            migrationBuilder.CreateIndex(
                name: "IX_LabRankingCodingParameters_ParameterId",
                table: "LabRankingCodingParameters",
                column: "ParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_LabRankingCodings_OwnershipStatusId",
                table: "LabRankingCodings",
                column: "OwnershipStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_LabRankingCodings_ParamClassificationId",
                table: "LabRankingCodings",
                column: "ParamClassificationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LabRankingCodingExpertPersonnels");

            migrationBuilder.DropTable(
                name: "LabRankingCodingParameters");

            migrationBuilder.DropTable(
                name: "LabRankingCodings");
        }
    }
}
