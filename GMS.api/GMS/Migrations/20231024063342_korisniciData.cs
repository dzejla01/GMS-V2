using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GMS.Migrations
{
    public partial class korisniciData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "ID",
                keyValue: 26,
                column: "Naziv",
                value: "Travnik");

            migrationBuilder.InsertData(
                table: "Korisnik",
                columns: new[] { "ID", "BrojTelefona", "GradID", "Ime", "Password", "Prezime", "SpolID", "TeretanaID", "Tezina", "Username", "Visina" },
                values: new object[] { 1, "0644076290", 18, "Vedad", "bayern123", "Keskin", 1, 2, 80f, "vedadke", 170f });

            migrationBuilder.InsertData(
                table: "Korisnik",
                columns: new[] { "ID", "BrojTelefona", "GradID", "Ime", "Password", "Prezime", "SpolID", "TeretanaID", "Tezina", "Username", "Visina" },
                values: new object[] { 2, "062709689", 26, "Džejla", "fit2023", "Palalić", 2, 2, 57f, "dzejlap", 164f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Korisnik",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Korisnik",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "ID",
                keyValue: 26,
                column: "Naziv",
                value: "Trebinje");
        }
    }
}
