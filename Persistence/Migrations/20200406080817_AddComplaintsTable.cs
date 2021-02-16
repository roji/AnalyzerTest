using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddComplaintsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Complaints",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    ComplaintRegion = table.Column<int>(nullable: false),
                    ProvinceId = table.Column<int>(nullable: true),
                    StateId = table.Column<int>(nullable: true),
                    DeputyId = table.Column<int>(nullable: true),
                    OfficeId = table.Column<int>(nullable: true),
                    OfficeGroupId = table.Column<int>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    NationalCode = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DocumentFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    AnwserSatisfaction = table.Column<bool>(nullable: true),
                    ComplaintDateTime = table.Column<DateTimeOffset>(nullable: false),
                    ExpertId = table.Column<int>(nullable: true),
                    Anwser = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_Complaints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Complaints_EnumData_DeputyId",
                        column: x => x.DeputyId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Complaints_Uploads_DocumentFileNameId",
                        column: x => x.DocumentFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Complaints_Users_ExpertId",
                        column: x => x.ExpertId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Complaints_EnumData_OfficeGroupId",
                        column: x => x.OfficeGroupId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Complaints_EnumData_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Complaints_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Complaints_EnumData_StateId",
                        column: x => x.StateId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Complaints_DeputyId",
                table: "Complaints",
                column: "DeputyId");

            migrationBuilder.CreateIndex(
                name: "IX_Complaints_DocumentFileNameId",
                table: "Complaints",
                column: "DocumentFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Complaints_ExpertId",
                table: "Complaints",
                column: "ExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_Complaints_OfficeGroupId",
                table: "Complaints",
                column: "OfficeGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Complaints_OfficeId",
                table: "Complaints",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Complaints_ProvinceId",
                table: "Complaints",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Complaints_StateId",
                table: "Complaints",
                column: "StateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Complaints");
        }
    }
}
