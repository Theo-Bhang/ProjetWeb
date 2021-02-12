using Microsoft.EntityFrameworkCore.Migrations;

namespace App.DAL.Migrations
{
    public partial class Final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Tasks");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Tasks",
                type: "nvarchar",
                nullable: false,
                defaultValue: null);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "Tasks");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
