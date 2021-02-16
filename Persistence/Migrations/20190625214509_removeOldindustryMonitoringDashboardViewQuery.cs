using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class removeOldindustryMonitoringDashboardViewQuery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var cmd = @"DROP VIEW IF EXISTS `v_industrymonitoringdashboard`;";
            migrationBuilder.Sql(cmd);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
