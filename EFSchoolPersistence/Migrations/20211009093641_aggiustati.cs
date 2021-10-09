using Microsoft.EntityFrameworkCore.Migrations;

namespace EFSchoolPersistence.Migrations
{
    public partial class aggiustati : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrezzoFinale",
                table: "StudeCourseEditions",
                newName: "FinalPrice");

            migrationBuilder.RenameColumn(
                name: "MinNumStudenti",
                table: "StudeCourseEditions",
                newName: "MinNumStudents");

            migrationBuilder.RenameColumn(
                name: "MaxNumStudenti",
                table: "StudeCourseEditions",
                newName: "MaxNumStudents");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MinNumStudents",
                table: "StudeCourseEditions",
                newName: "MinNumStudenti");

            migrationBuilder.RenameColumn(
                name: "MaxNumStudents",
                table: "StudeCourseEditions",
                newName: "MaxNumStudenti");

            migrationBuilder.RenameColumn(
                name: "FinalPrice",
                table: "StudeCourseEditions",
                newName: "PrezzoFinale");
        }
    }
}
