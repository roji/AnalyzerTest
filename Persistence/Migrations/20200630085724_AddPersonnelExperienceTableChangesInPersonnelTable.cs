using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddPersonnelExperienceTableChangesInPersonnelTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AirSoundJobExperience",
                table: "Personnels");

            migrationBuilder.DropColumn(
                name: "BiologyJobExperience",
                table: "Personnels");

            migrationBuilder.DropColumn(
                name: "PhysicsChemistryJobExperience",
                table: "Personnels");

            migrationBuilder.DropColumn(
                name: "isExpertInAirSound",
                table: "Personnels");

            migrationBuilder.DropColumn(
                name: "isExpertInBiology",
                table: "Personnels");

            migrationBuilder.DropColumn(
                name: "isExpertInPhysicsChemistry",
                table: "Personnels");

            migrationBuilder.CreateTable(
                name: "PersonnelExperiences",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MonitoringTypeId = table.Column<int>(nullable: false),
                    Experience = table.Column<int>(nullable: false),
                    PersonnelId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_PersonnelExperiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonnelExperiences_EnumData_MonitoringTypeId",
                        column: x => x.MonitoringTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonnelExperiences_Personnels_PersonnelId",
                        column: x => x.PersonnelId,
                        principalTable: "Personnels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelExperiences_MonitoringTypeId",
                table: "PersonnelExperiences",
                column: "MonitoringTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelExperiences_PersonnelId",
                table: "PersonnelExperiences",
                column: "PersonnelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonnelExperiences");

            migrationBuilder.AddColumn<int>(
                name: "AirSoundJobExperience",
                table: "Personnels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BiologyJobExperience",
                table: "Personnels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhysicsChemistryJobExperience",
                table: "Personnels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isExpertInAirSound",
                table: "Personnels",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isExpertInBiology",
                table: "Personnels",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isExpertInPhysicsChemistry",
                table: "Personnels",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
