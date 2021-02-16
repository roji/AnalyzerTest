using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveWasteTransportationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WasteTransportation");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WasteTransportation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    DesAdminAgreement = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DesAdminAgreementDate = table.Column<int>(type: "int", nullable: true),
                    DesAdminAgreementFileNameId = table.Column<string>(type: "varchar(38)", maxLength: 38, nullable: true),
                    Description = table.Column<string>(type: "longtext", nullable: true),
                    EliminationFormFileNameId = table.Column<string>(type: "varchar(38)", maxLength: 38, nullable: true),
                    LoadingSupervisionAgendaFileNameId = table.Column<string>(type: "varchar(38)", maxLength: 38, nullable: true),
                    ModifiedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    PostedDate = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    RecievedDate = table.Column<int>(type: "int", nullable: true),
                    RecieverIndustryId = table.Column<int>(type: "int", nullable: false),
                    RequestDate = table.Column<int>(type: "int", nullable: true),
                    RoadTransportRegulationsObserved = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    RtroDescription = table.Column<string>(type: "longtext", nullable: true),
                    SaleInvoiceFileNameId = table.Column<string>(type: "varchar(38)", maxLength: 38, nullable: true),
                    SenderIndustryId = table.Column<int>(type: "int", nullable: false),
                    SubmissionMethodId = table.Column<int>(type: "int", nullable: true),
                    SupervisionOverDischargeFileNameId = table.Column<string>(type: "varchar(38)", maxLength: 38, nullable: true),
                    WasteAnalysisFileNameId = table.Column<string>(type: "varchar(38)", maxLength: 38, nullable: true),
                    WasteId = table.Column<int>(type: "int", nullable: false),
                    WasteTransportStatus = table.Column<int>(type: "int", nullable: false),
                    WaybillFileNameId = table.Column<string>(type: "varchar(38)", maxLength: 38, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WasteTransportation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WasteTransportation_Uploads_DesAdminAgreementFileNameId",
                        column: x => x.DesAdminAgreementFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteTransportation_Uploads_EliminationFormFileNameId",
                        column: x => x.EliminationFormFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteTransportation_Uploads_LoadingSupervisionAgendaFileName~",
                        column: x => x.LoadingSupervisionAgendaFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteTransportation_Industries_RecieverIndustryId",
                        column: x => x.RecieverIndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteTransportation_Uploads_SaleInvoiceFileNameId",
                        column: x => x.SaleInvoiceFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteTransportation_Industries_SenderIndustryId",
                        column: x => x.SenderIndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteTransportation_EnumData_SubmissionMethodId",
                        column: x => x.SubmissionMethodId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteTransportation_Uploads_SupervisionOverDischargeFileName~",
                        column: x => x.SupervisionOverDischargeFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteTransportation_Uploads_WasteAnalysisFileNameId",
                        column: x => x.WasteAnalysisFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteTransportation_Wastes_WasteId",
                        column: x => x.WasteId,
                        principalTable: "Wastes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteTransportation_Uploads_WaybillFileNameId",
                        column: x => x.WaybillFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransportation_DesAdminAgreementFileNameId",
                table: "WasteTransportation",
                column: "DesAdminAgreementFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransportation_EliminationFormFileNameId",
                table: "WasteTransportation",
                column: "EliminationFormFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransportation_LoadingSupervisionAgendaFileNameId",
                table: "WasteTransportation",
                column: "LoadingSupervisionAgendaFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransportation_RecieverIndustryId",
                table: "WasteTransportation",
                column: "RecieverIndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransportation_SaleInvoiceFileNameId",
                table: "WasteTransportation",
                column: "SaleInvoiceFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransportation_SenderIndustryId",
                table: "WasteTransportation",
                column: "SenderIndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransportation_SubmissionMethodId",
                table: "WasteTransportation",
                column: "SubmissionMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransportation_SupervisionOverDischargeFileNameId",
                table: "WasteTransportation",
                column: "SupervisionOverDischargeFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransportation_WasteAnalysisFileNameId",
                table: "WasteTransportation",
                column: "WasteAnalysisFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransportation_WasteId",
                table: "WasteTransportation",
                column: "WasteId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransportation_WaybillFileNameId",
                table: "WasteTransportation",
                column: "WaybillFileNameId");
        }
    }
}
