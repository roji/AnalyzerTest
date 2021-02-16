using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddSecretKeyTemplateAndGeneratedDateFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "SecretKeyGeneratedDate",
                table: "Users",
                nullable: false,
                defaultValueSql: "UTC_TIMESTAMP()");

            migrationBuilder.AddColumn<string>(
                name: "SecretKeyTemplate",
                table: "Users",
                maxLength: 8,
                nullable: false,
                defaultValueSql: "SUBSTRING(UUID(), 1, 8)");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SecretKeyTemplate",
                table: "Users",
                column: "SecretKeyTemplate",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_SecretKeyTemplate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecretKeyGeneratedDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecretKeyTemplate",
                table: "Users");
        }
    }
}
