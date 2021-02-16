using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ChangeBankColumnTobeEnumData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bank",
                table: "AccountNumbers");

            migrationBuilder.AddColumn<int>(
                name: "BankId",
                table: "AccountNumbers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AccountNumbers_BankId",
                table: "AccountNumbers",
                column: "BankId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountNumbers_EnumData_BankId",
                table: "AccountNumbers",
                column: "BankId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountNumbers_EnumData_BankId",
                table: "AccountNumbers");

            migrationBuilder.DropIndex(
                name: "IX_AccountNumbers_BankId",
                table: "AccountNumbers");

            migrationBuilder.DropColumn(
                name: "BankId",
                table: "AccountNumbers");

            migrationBuilder.AddColumn<string>(
                name: "Bank",
                table: "AccountNumbers",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");
        }
    }
}
