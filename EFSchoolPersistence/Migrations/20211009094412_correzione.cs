using Microsoft.EntityFrameworkCore.Migrations;

namespace EFSchoolPersistence.Migrations
{
    public partial class correzione : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudeCourseEditions_Courses_CourseId",
                table: "StudeCourseEditions");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_StudeCourseEditions_CourseEditionId",
                table: "Subscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudeCourseEditions",
                table: "StudeCourseEditions");

            migrationBuilder.RenameTable(
                name: "StudeCourseEditions",
                newName: "CourseEditions");

            migrationBuilder.RenameIndex(
                name: "IX_StudeCourseEditions_CourseId",
                table: "CourseEditions",
                newName: "IX_CourseEditions_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseEditions",
                table: "CourseEditions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseEditions_Courses_CourseId",
                table: "CourseEditions",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_CourseEditions_CourseEditionId",
                table: "Subscriptions",
                column: "CourseEditionId",
                principalTable: "CourseEditions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseEditions_Courses_CourseId",
                table: "CourseEditions");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_CourseEditions_CourseEditionId",
                table: "Subscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseEditions",
                table: "CourseEditions");

            migrationBuilder.RenameTable(
                name: "CourseEditions",
                newName: "StudeCourseEditions");

            migrationBuilder.RenameIndex(
                name: "IX_CourseEditions_CourseId",
                table: "StudeCourseEditions",
                newName: "IX_StudeCourseEditions_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudeCourseEditions",
                table: "StudeCourseEditions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudeCourseEditions_Courses_CourseId",
                table: "StudeCourseEditions",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_StudeCourseEditions_CourseEditionId",
                table: "Subscriptions",
                column: "CourseEditionId",
                principalTable: "StudeCourseEditions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
