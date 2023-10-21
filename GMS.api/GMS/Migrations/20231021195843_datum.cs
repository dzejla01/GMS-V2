using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GMS.Migrations
{
    public partial class datum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Korisnik_Clanarina",
                table: "Korisnik_Clanarina");

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumUplate",
                table: "Korisnik_Clanarina",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumIsteka",
                table: "Korisnik_Clanarina",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Korisnik_Clanarina",
                table: "Korisnik_Clanarina",
                columns: new[] { "ClanarinaID", "KorisnikID", "DatumUplate" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Korisnik_Clanarina",
                table: "Korisnik_Clanarina");

            migrationBuilder.DropColumn(
                name: "DatumUplate",
                table: "Korisnik_Clanarina");

            migrationBuilder.DropColumn(
                name: "DatumIsteka",
                table: "Korisnik_Clanarina");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Korisnik_Clanarina",
                table: "Korisnik_Clanarina",
                columns: new[] { "ClanarinaID", "KorisnikID" });
        }
    }
}
