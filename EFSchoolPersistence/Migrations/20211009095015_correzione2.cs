using Microsoft.EntityFrameworkCore.Migrations;

namespace EFSchoolPersistence.Migrations
{
    public partial class correzione2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_Students_StudentId",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Subscriptions");

            migrationBuilder.AlterColumn<long>(
                name: "StudentId",
                table: "Subscriptions",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_Students_StudentId",
                table: "Subscriptions",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_Students_StudentId",
                table: "Subscriptions");

            migrationBuilder.AlterColumn<long>(
                name: "StudentId",
                table: "Subscriptions",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "PersonId",
                table: "Subscriptions",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_Students_StudentId",
                table: "Subscriptions",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
