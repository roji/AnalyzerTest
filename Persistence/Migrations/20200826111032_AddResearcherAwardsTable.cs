﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddResearcherAwardsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ResearcherAwards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Presenter = table.Column<string>(maxLength: 256, nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ResearcherId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_ResearcherAwards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResearcherAwards_Researchers_ResearcherId",
                        column: x => x.ResearcherId,
                        principalTable: "Researchers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResearcherAwards_ResearcherId",
                table: "ResearcherAwards",
                column: "ResearcherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResearcherAwards");
        }
    }
}
