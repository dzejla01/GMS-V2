using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GMS.Migrations
{
    public partial class spajanjeGym : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeretanaID",
                table: "Korisnik",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_TeretanaID",
                table: "Korisnik",
                column: "TeretanaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Korisnik_Teretana_TeretanaID",
                table: "Korisnik",
                column: "TeretanaID",
                principalTable: "Teretana",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korisnik_Teretana_TeretanaID",
                table: "Korisnik");

            migrationBuilder.DropIndex(
                name: "IX_Korisnik_TeretanaID",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "TeretanaID",
                table: "Korisnik");
        }
    }
}
