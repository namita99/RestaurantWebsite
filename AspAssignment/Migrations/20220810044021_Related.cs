using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspAssignment.Migrations
{
    public partial class Related : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "Orders",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderDateTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "TableName",
                table: "Orders",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderDateTime",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "TableName",
                table: "Orders");
        }
    }
}
