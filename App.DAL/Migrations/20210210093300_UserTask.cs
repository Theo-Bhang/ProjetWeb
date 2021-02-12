using Microsoft.EntityFrameworkCore.Migrations;

namespace App.DAL.Migrations
{
    public partial class UserTask : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AssignedTask",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignedTask",
                table: "Users");
        }
    }
}
