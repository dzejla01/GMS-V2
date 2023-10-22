using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GMS.Migrations
{
    public partial class KorisnikTrenerTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_Trener_TrenerID",
                table: "Korisnik_Trener",
                column: "TrenerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Korisnik_Trener_Korisnik_KorisnikID",
                table: "Korisnik_Trener",
                column: "KorisnikID",
                principalTable: "Korisnik",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Korisnik_Trener_Trener_TrenerID",
                table: "Korisnik_Trener",
                column: "TrenerID",
                principalTable: "Trener",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korisnik_Trener_Korisnik_KorisnikID",
                table: "Korisnik_Trener");

            migrationBuilder.DropForeignKey(
                name: "FK_Korisnik_Trener_Trener_TrenerID",
                table: "Korisnik_Trener");

            migrationBuilder.DropIndex(
                name: "IX_Korisnik_Trener_TrenerID",
                table: "Korisnik_Trener");
        }
    }
}
