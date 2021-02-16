using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddInformationValidationTableAndAddRelatedFieldsToLabIndustry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ValidationScore",
                table: "Labs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ValidationScore",
                table: "Industries",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "InformationValidations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Vote = table.Column<bool>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    IndustryValidationScore = table.Column<int>(nullable: true),
                    LabValidationScore = table.Column<int>(nullable: true),
                    DescriptionDate = table.Column<DateTimeOffset>(nullable: false),
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
                    table.PrimaryKey("PK_InformationValidations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InformationValidations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InformationValidations_UserId",
                table: "InformationValidations",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InformationValidations");

            migrationBuilder.DropColumn(
                name: "ValidationScore",
                table: "Labs");

            migrationBuilder.DropColumn(
                name: "ValidationScore",
                table: "Industries");
        }
    }
}
