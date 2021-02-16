using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddNewFieldsToIndustryPollutionTableIncludeComitteeResultsVote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CommitteeResultVote",
                table: "IndustryPollutions",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FinalSave",
                table: "IndustryPollutions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "FinalSaveDate",
                table: "IndustryPollutions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GeneralManagerDescription",
                table: "IndustryPollutions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GeneralManagerVote",
                table: "IndustryPollutions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeadOfCountyOfficeDescription",
                table: "IndustryPollutions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HeadOfCountyOfficeVote",
                table: "IndustryPollutions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeadOfHumanEnvironmentDescription",
                table: "IndustryPollutions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HeadOfHumanEnvironmentVote",
                table: "IndustryPollutions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeadOfLaboratoryAdministrationDescription",
                table: "IndustryPollutions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HeadOfLaboratoryAdministrationVote",
                table: "IndustryPollutions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeadOfMonitoringDepartmentDescription",
                table: "IndustryPollutions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HeadOfMonitoringDepartmentVote",
                table: "IndustryPollutions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LegalAssistantDescription",
                table: "IndustryPollutions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LegalAssistantVote",
                table: "IndustryPollutions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TechnicalAssistantDescription",
                table: "IndustryPollutions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TechnicalAssistantVote",
                table: "IndustryPollutions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommitteeResultVote",
                table: "IndustryPollutions");

            migrationBuilder.DropColumn(
                name: "FinalSave",
                table: "IndustryPollutions");

            migrationBuilder.DropColumn(
                name: "FinalSaveDate",
                table: "IndustryPollutions");

            migrationBuilder.DropColumn(
                name: "GeneralManagerDescription",
                table: "IndustryPollutions");

            migrationBuilder.DropColumn(
                name: "GeneralManagerVote",
                table: "IndustryPollutions");

            migrationBuilder.DropColumn(
                name: "HeadOfCountyOfficeDescription",
                table: "IndustryPollutions");

            migrationBuilder.DropColumn(
                name: "HeadOfCountyOfficeVote",
                table: "IndustryPollutions");

            migrationBuilder.DropColumn(
                name: "HeadOfHumanEnvironmentDescription",
                table: "IndustryPollutions");

            migrationBuilder.DropColumn(
                name: "HeadOfHumanEnvironmentVote",
                table: "IndustryPollutions");

            migrationBuilder.DropColumn(
                name: "HeadOfLaboratoryAdministrationDescription",
                table: "IndustryPollutions");

            migrationBuilder.DropColumn(
                name: "HeadOfLaboratoryAdministrationVote",
                table: "IndustryPollutions");

            migrationBuilder.DropColumn(
                name: "HeadOfMonitoringDepartmentDescription",
                table: "IndustryPollutions");

            migrationBuilder.DropColumn(
                name: "HeadOfMonitoringDepartmentVote",
                table: "IndustryPollutions");

            migrationBuilder.DropColumn(
                name: "LegalAssistantDescription",
                table: "IndustryPollutions");

            migrationBuilder.DropColumn(
                name: "LegalAssistantVote",
                table: "IndustryPollutions");

            migrationBuilder.DropColumn(
                name: "TechnicalAssistantDescription",
                table: "IndustryPollutions");

            migrationBuilder.DropColumn(
                name: "TechnicalAssistantVote",
                table: "IndustryPollutions");
        }
    }
}
