using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RenameMultipleViewsAndDashboards : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var cmd = @"
            RENAME TABLE v_industrymonitoringmaplist
            TO v_monitoringrequiredindustrymaplist;

            RENAME TABLE v_monitoringtypemaplist
            TO v_finishedmonitoringtypesmaplist;

            RENAME TABLE v_industrypollutiondashboard
            TO v_pollutiontaxesdashboard;

            RENAME TABLE v_monitoringtypedashboard
            TO v_monitoringtypesfinishedsamplingsstatsdashboard;";
            migrationBuilder.Sql(cmd);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var cmd = @"
            RENAME TABLE v_monitoringrequiredindustrymaplist
            TO v_industrymonitoringmaplist;

            RENAME TABLE v_finishedmonitoringtypesmaplist
            TO v_monitoringtypemaplist;

            RENAME TABLE v_pollutiontaxesdashboard
            TO v_industrypollutiondashboard;

            RENAME TABLE v_monitoringtypesfinishedsamplingsstatsdashboard
            TO v_monitoringtypedashboard;";
            migrationBuilder.Sql(cmd);
        }
    }
}
