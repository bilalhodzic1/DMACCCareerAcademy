using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeScheduler.Migrations
{
    public partial class Adjustment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalHours",
                table: "shifts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalHours",
                table: "shifts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
