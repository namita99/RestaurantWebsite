using Microsoft.EntityFrameworkCore.Migrations;

namespace AspAssignment.Migrations
{
    public partial class RelatedForm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderDateTime",
                table: "Orders",
                newName: "OrderDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "Orders",
                newName: "OrderDateTime");
        }
    }
}
