using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveComplaintTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Complaints");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Complaints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(type: "longtext", nullable: true),
                    Answer = table.Column<string>(type: "longtext", nullable: true),
                    AnswerDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    AnswerSatisfaction = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    AnswerStartPendingDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    ComplaintDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    ComplaintRegion = table.Column<int>(type: "int", nullable: false),
                    CreatedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    DeputyId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "longtext", nullable: true),
                    DocumentFileNameId = table.Column<string>(type: "varchar(38)", maxLength: 38, nullable: true),
                    Email = table.Column<string>(type: "longtext", nullable: true),
                    ExpertId = table.Column<int>(type: "int", nullable: true),
                    FullName = table.Column<string>(type: "longtext", nullable: true),
                    Mobile = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    NationalCode = table.Column<string>(type: "longtext", nullable: true),
                    OfficeGroupId = table.Column<int>(type: "int", nullable: true),
                    OfficeId = table.Column<int>(type: "int", nullable: true),
                    ProvinceId = table.Column<int>(type: "int", nullable: true),
                    StateId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Subject = table.Column<string>(type: "longtext", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false)
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
    }
}
