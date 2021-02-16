using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddIndustryEstablishmentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IndustryEstablishments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RequestDate = table.Column<DateTimeOffset>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    StateOfficeExpertId = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_IndustryEstablishments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishments_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishments_Users_StateOfficeExpertId",
                        column: x => x.StateOfficeExpertId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IndustryEstablishmentDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IndustryEstablishmentId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    UserType = table.Column<string>(nullable: true),
                    UserComment = table.Column<string>(nullable: true),
                    SystemComment = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_IndustryEstablishmentDescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentDescriptions_IndustryEstablishments_Ind~",
                        column: x => x.IndustryEstablishmentId,
                        principalTable: "IndustryEstablishments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndustryEstablishmentDescriptions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentDescriptions_IndustryEstablishmentId",
                table: "IndustryEstablishmentDescriptions",
                column: "IndustryEstablishmentId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishmentDescriptions_UserId",
                table: "IndustryEstablishmentDescriptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishments_IndustryId",
                table: "IndustryEstablishments",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishments_StateOfficeExpertId",
                table: "IndustryEstablishments",
                column: "StateOfficeExpertId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndustryEstablishmentDescriptions");

            migrationBuilder.DropTable(
                name: "IndustryEstablishments");
        }
    }
}
