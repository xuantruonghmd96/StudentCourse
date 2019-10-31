using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentCourse.Migrations
{
    public partial class Student_Add_Donated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Donated",
                table: "StudentCourseMaps",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Donated",
                table: "StudentCourseMaps");
        }
    }
}
