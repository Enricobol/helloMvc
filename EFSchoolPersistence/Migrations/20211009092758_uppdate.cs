using Microsoft.EntityFrameworkCore.Migrations;

namespace EFSchoolPersistence.Migrations
{
    public partial class uppdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titolo",
                table: "Courses",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Descrizione",
                table: "Courses",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "CostoRiferimento",
                table: "Courses",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "AmmontareOre",
                table: "Courses",
                newName: "TotalHours");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalHours",
                table: "Courses",
                newName: "AmmontareOre");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Courses",
                newName: "Titolo");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Courses",
                newName: "CostoRiferimento");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Courses",
                newName: "Descrizione");
        }
    }
}
