using Microsoft.EntityFrameworkCore.Migrations;

namespace AspAssignment.Migrations
{
    public partial class RelatedOrderTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TableName",
                table: "OrderDetails",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TableName",
                table: "OrderDetails");
        }
    }
}
