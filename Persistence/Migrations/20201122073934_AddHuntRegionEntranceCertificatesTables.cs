using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddHuntRegionEntranceCertificatesTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HuntRegionEntranceCertificates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<int>(nullable: false, defaultValue: 2),
                    RequestDate = table.Column<DateTimeOffset>(nullable: false),
                    IssueDate = table.Column<DateTimeOffset>(nullable: true),
                    ApprovingDuration = table.Column<int>(nullable: true),
                    HuntingLicenseId = table.Column<int>(nullable: false),
                    EntranceDateId = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_HuntRegionEntranceCertificates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HuntRegionEntranceCertificates_HuntingLicenses_HuntingLicens~",
                        column: x => x.HuntingLicenseId,
                        principalTable: "HuntingLicenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HuntRegionEntranceCertificateDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HuntRegionEntranceCertificateId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    UserType = table.Column<string>(nullable: true),
                    UserComment = table.Column<string>(nullable: true),
                    SystemComment = table.Column<string>(nullable: true),
                    DescriptionDate = table.Column<DateTimeOffset>(nullable: false),
                    DescriptionType = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_HuntRegionEntranceCertificateDescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HuntRegionEntranceCertificateDescriptions_HuntRegionEntrance~",
                        column: x => x.HuntRegionEntranceCertificateId,
                        principalTable: "HuntRegionEntranceCertificates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HuntRegionEntranceCertificateDescriptions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HuntRegionEntranceCertificateOfferingDates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<int>(nullable: false),
                    Hour = table.Column<string>(maxLength: 10, nullable: false),
                    HuntRegionEntranceCertificateId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_HuntRegionEntranceCertificateOfferingDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HuntRegionEntranceCertificateOfferingDates_HuntRegionEntranc~",
                        column: x => x.HuntRegionEntranceCertificateId,
                        principalTable: "HuntRegionEntranceCertificates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HuntRegionEntranceCertificateDescriptions_HuntRegionEntrance~",
                table: "HuntRegionEntranceCertificateDescriptions",
                column: "HuntRegionEntranceCertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_HuntRegionEntranceCertificateDescriptions_UserId",
                table: "HuntRegionEntranceCertificateDescriptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HuntRegionEntranceCertificateOfferingDates_HuntRegionEntranc~",
                table: "HuntRegionEntranceCertificateOfferingDates",
                column: "HuntRegionEntranceCertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_HuntRegionEntranceCertificates_EntranceDateId",
                table: "HuntRegionEntranceCertificates",
                column: "EntranceDateId");

            migrationBuilder.CreateIndex(
                name: "IX_HuntRegionEntranceCertificates_HuntingLicenseId",
                table: "HuntRegionEntranceCertificates",
                column: "HuntingLicenseId");

            migrationBuilder.AddForeignKey(
                name: "FK_HuntRegionEntranceCertificates_HuntRegionEntranceCertificate~",
                table: "HuntRegionEntranceCertificates",
                column: "EntranceDateId",
                principalTable: "HuntRegionEntranceCertificateOfferingDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HuntRegionEntranceCertificateOfferingDates_HuntRegionEntranc~",
                table: "HuntRegionEntranceCertificateOfferingDates");

            migrationBuilder.DropTable(
                name: "HuntRegionEntranceCertificateDescriptions");

            migrationBuilder.DropTable(
                name: "HuntRegionEntranceCertificates");

            migrationBuilder.DropTable(
                name: "HuntRegionEntranceCertificateOfferingDates");
        }
    }
}
