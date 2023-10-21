using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GMS.Migrations
{
    public partial class KorisnikUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BrojTelefona",
                table: "Korisnik",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Korisnik",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "Tezina",
                table: "Korisnik",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Korisnik",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "Visina",
                table: "Korisnik",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrojTelefona",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "Tezina",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "Visina",
                table: "Korisnik");
        }
    }
}
