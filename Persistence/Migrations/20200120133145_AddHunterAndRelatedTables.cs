using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddHunterAndRelatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hunters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HunterType = table.Column<int>(nullable: false),
                    PreviousProvinceIdentityCode = table.Column<string>(nullable: true),
                    PreviousNationalIdentityCode = table.Column<string>(nullable: true),
                    AutomaticNationalIdentityCode = table.Column<string>(nullable: true),
                    RegisterDate = table.Column<int>(nullable: true),
                    AcceptedCommitmentForm = table.Column<bool>(nullable: true),
                    PhotoFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    NationalCardFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    BirthCertificateFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    CommitmentFormFileNameId = table.Column<string>(maxLength: 38, nullable: true),
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
                    table.PrimaryKey("PK_Hunters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hunters_Uploads_BirthCertificateFileNameId",
                        column: x => x.BirthCertificateFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hunters_Uploads_CommitmentFormFileNameId",
                        column: x => x.CommitmentFormFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hunters_Uploads_NationalCardFileNameId",
                        column: x => x.NationalCardFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hunters_Uploads_PhotoFileNameId",
                        column: x => x.PhotoFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HunterAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Mobile = table.Column<string>(nullable: true),
                    ProvinceId = table.Column<int>(nullable: true),
                    StateId = table.Column<int>(nullable: true),
                    CityId = table.Column<int>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_HunterAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HunterAddresses_EnumData_CityId",
                        column: x => x.CityId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HunterAddresses_Hunters_HunterId",
                        column: x => x.HunterId,
                        principalTable: "Hunters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HunterAddresses_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HunterAddresses_EnumData_StateId",
                        column: x => x.StateId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HunterInformations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    SurvivalStatus = table.Column<bool>(nullable: true),
                    NationalCode = table.Column<string>(nullable: true),
                    FatherName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<int>(nullable: true),
                    ReligionId = table.Column<int>(nullable: true),
                    Faith = table.Column<string>(nullable: true),
                    GradeId = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_HunterInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HunterInformations_EnumData_GradeId",
                        column: x => x.GradeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HunterInformations_Hunters_HunterId",
                        column: x => x.HunterId,
                        principalTable: "Hunters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HunterInformations_EnumData_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HunterAddresses_CityId",
                table: "HunterAddresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterAddresses_HunterId",
                table: "HunterAddresses",
                column: "HunterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HunterAddresses_ProvinceId",
                table: "HunterAddresses",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterAddresses_StateId",
                table: "HunterAddresses",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterInformations_GradeId",
                table: "HunterInformations",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_HunterInformations_HunterId",
                table: "HunterInformations",
                column: "HunterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HunterInformations_ReligionId",
                table: "HunterInformations",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_Hunters_BirthCertificateFileNameId",
                table: "Hunters",
                column: "BirthCertificateFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Hunters_CommitmentFormFileNameId",
                table: "Hunters",
                column: "CommitmentFormFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Hunters_NationalCardFileNameId",
                table: "Hunters",
                column: "NationalCardFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Hunters_PhotoFileNameId",
                table: "Hunters",
                column: "PhotoFileNameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HunterAddresses");

            migrationBuilder.DropTable(
                name: "HunterInformations");

            migrationBuilder.DropTable(
                name: "Hunters");
        }
    }
}
